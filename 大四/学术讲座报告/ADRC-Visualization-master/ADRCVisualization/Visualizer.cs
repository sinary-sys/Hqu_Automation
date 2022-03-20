using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ADRCVisualization.Class_Files;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ADRCVisualization
{
    public partial class Visualizer : Form
    {
        private BackgroundWorker backgroundWorker;
        private DateTime dateTime;
        private bool correctionState;

        //Inverted Pendulum
        private double SetPoint = 0;
        private double StartPoint = 30;
        private double PendulumLength = 4;
        private double PendulumMass = 2;
        private double NoiseFactor = 0;
        
        //FeedbackControllers
        private double maxOutput = 1000;
        private bool initializeFeedbackControllers = false;
        private double WaitTimeForCalculation = 5;
        private double RunTime = 20;

        //Proportional Integral Derivative Parameters
        private List<float> PIDOutput = new List<float>();
        private List<float> PIDAngle = new List<float>();
        private InvertedPendulum invertedPendulumPID;
        private StreamWriter pidFileWriter;
        private KalmanFilter pidMaxValue;
        private PID pid;
        private double kp = 0.36;
        private double ki = 0;
        private double kd = 0.2485;//0.18
        private double anglePID;
        private double outputPID;
        private int pidCounter = 0;

        //Active Disturbance Rejection Control Parameters
        private List<float> ADRCOutput = new List<float>();
        private List<float> ADRCAngle = new List<float>();
        private InvertedPendulum invertedPendulumADRC;
        private StreamWriter adrcFileWriter;
        private KalmanFilter adrcMaxValue;
        private ADRC_PD adrc;
        private double r = 2000;//80
        private double c = 500;//500
        private double b = 2.875;//0.5   smoothing
        private double hModifier = 0.00085;//0.005   overshoot
        private double angleADRC;
        private double outputADRC;
        private int adrcCounter = 0;

        //Timers for alternate threads and asynchronous calculations
        private System.Timers.Timer t1;
        private System.Timers.Timer t2;
        private System.Timers.Timer t3;

        //Fourier Transforms
        private FourierBitmap PIDFourierBitmap;
        private FourierBitmap ADRCFourierBitmap;
        private float FourierTolerance = 1f;
        
        public Visualizer()
        {
            InitializeComponent();
            
            dateTime = DateTime.Now;
            correctionState = false;

            InitializeFileWriters();

            InitializeCharts();

            PIDFourierBitmap = new FourierBitmap(710, 350, (float)maxOutput);
            ADRCFourierBitmap = new FourierBitmap(710, 350, (float)maxOutput);

            pidMaxValue = new KalmanFilter(0.001, 20);
            adrcMaxValue = new KalmanFilter(0.001, 20);

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_CalculateFourierTransforms);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_ChangeFourierTransforms);

            StartTimers();
            StopTimers();
        }

        /// <summary>
        /// Creates the file writers and adds headers to the files
        /// </summary>
        private void InitializeFileWriters()
        {
            adrcFileWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ADRCData.csv");
            pidFileWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PIDData.csv");

            adrcFileWriter.WriteLine("r,c,b,h");
            adrcFileWriter.WriteLine(r + "," + c + "," + b + "," + hModifier);

            adrcFileWriter.WriteLine();

            pidFileWriter.WriteLine("KP,KI,KD");
            pidFileWriter.WriteLine(kp + "," + ki + "," + kd);

            pidFileWriter.WriteLine();
        }

        private void InitializeCharts()
        {
            chart1.ChartAreas[0].AxisY.Maximum = 360;
            chart1.ChartAreas[0].AxisY.Minimum = -60;

            chart3.Series[0].Points.Add(0);
            chart4.Series[0].Points.Add(0);

            chart3.ChartAreas[0].AxisY.Maximum = maxOutput;
            chart3.ChartAreas[0].AxisY.Minimum = -maxOutput;

            chart4.ChartAreas[0].AxisY.Maximum = maxOutput;
            chart4.ChartAreas[0].AxisY.Minimum = -maxOutput;
        }

        /// <summary>
        /// Starts alternate threads for calculation of the inverted pendulum and updating the display of the user interface for the FFTWs, pendulum, and graphs.
        /// </summary>
        private async void StartTimers()
        {
            await Task.Delay(50);

            this.BeginInvoke((Action)(() =>
            {
                invertedPendulumPID = new InvertedPendulum(StartPoint, PendulumLength, PendulumMass);//start angle, arm length
                invertedPendulumADRC = new InvertedPendulum(StartPoint, PendulumLength, PendulumMass);//start angle, arm length
                
                t1 = new System.Timers.Timer
                {
                    Interval = 60, //In milliseconds here
                    AutoReset = true //Stops it from repeating
                };
                t1.Elapsed += new ElapsedEventHandler(SetInvertedPendulumAngle);
                t1.Start();

                t2 = new System.Timers.Timer
                {
                    Interval = 1, //In milliseconds here
                    AutoReset = true //Stops it from repeating
                };
                t2.Elapsed += new ElapsedEventHandler(ChangeAngle);
                t2.Start();
                
                t3 = new System.Timers.Timer
                {
                    Interval = 250, //In milliseconds here
                    AutoReset = true //Stops it from repeating
                };
                t3.Elapsed += new ElapsedEventHandler(UpdateFourierTransforms);
                t3.Start();
            }));
        }

        /// <summary>
        /// Stops the secondary threads to end the calculation.
        /// </summary>
        private async void StopTimers()
        {
            await Task.Delay((int)RunTime * 1000);

            this.BeginInvoke((Action)(() =>
            {
                t1.Stop();
                t2.Stop();
                t3.Stop();

                label1.Text = "Calculation Stopped";
            }));
        }
        
        /// <summary>
        /// Why FFT?
        /// -Displays change of frequency of pendulum, slowing/speeding up
        /// -Displays noise effectively from output
        /// -Displays switching frequency of feedback controller
        /// 
        /// Updates the Fourier Transform charts and 2d memory displays.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateFourierTransforms(object sender, ElapsedEventArgs e)
        {
            if (!(DateTime.Now.Subtract(dateTime).TotalSeconds > RunTime))
            {
                this.BeginInvoke((Action)(() =>
                {
                    if (PIDOutput.ToArray().Length > 1)//FourierTransform.FourierMemory / 1.25)
                    {
                        chart3.Series[0].Points.Clear();
                        chart4.Series[0].Points.Clear();

                        chart3.Series[1].Points.Clear();
                        chart4.Series[1].Points.Clear();

                        while (!backgroundWorker.IsBusy)
                        {
                            try
                            {
                                backgroundWorker.RunWorkerAsync();
                                break;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                }));
            }
        }
        
        /// <summary>
        /// Changes the angle of the pendulums and calculates the corrections for the feedback controllers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeAngle(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.Subtract(dateTime).TotalSeconds > WaitTimeForCalculation)
            {
                if (!initializeFeedbackControllers)
                {
                    pid = new PID(kp, ki, kd, maxOutput);
                    adrc = new ADRC_PD(r, c, b, hModifier, kp, kd, maxOutput);
                    
                    initializeFeedbackControllers = true;
                }

                correctionState = true;
                outputPID = pid.Calculate(SetPoint, anglePID);
                outputADRC = adrc.Calculate(SetPoint, angleADRC);

                pidFileWriter.WriteLine(pidCounter + "," + outputPID + "," + anglePID);
                adrcFileWriter.WriteLine(adrcCounter + "," + outputADRC + "," + angleADRC);

                pidCounter++;
                adrcCounter++;

                ADRCAngle.Add((float)angleADRC);
                PIDAngle.Add((float)anglePID);
                
                ADRCOutput.Add((float)outputADRC);
                PIDOutput.Add((float)outputPID);

                if (ADRCAngle.ToArray().Length > FourierTransform.FourierMemory)
                {
                    ADRCAngle.RemoveAt(0);
                    PIDAngle.RemoveAt(0);
                    ADRCOutput.RemoveAt(0);
                    PIDOutput.RemoveAt(0);
                }
            }

            Random rand = new Random();

            double noise = rand.NextDouble() * NoiseFactor * (rand.Next(0, 1) * 2 - 1);

            double tempAnglePID = (invertedPendulumPID.Step(-outputPID) * 180 / Math.PI + noise);// % 360;
            double tempAngleADRC = (invertedPendulumADRC.Step(-outputADRC) * 180 / Math.PI + noise);// % 360;

            anglePID = tempAnglePID;
            angleADRC = tempAngleADRC;
        }
        
        /// <summary>
        /// Updates the diplay of the inverted pendulums and the charts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetInvertedPendulumAngle(object sender, ElapsedEventArgs e)
        {
            if (!(DateTime.Now.Subtract(dateTime).TotalSeconds > RunTime))
            {
                this.BeginInvoke((Action)(() =>
                {
                    label1.Text = "Correction State: " + correctionState.ToString();

                    chart1.Series[0].Points.Add(anglePID);
                    chart1.Series[1].Points.Add(angleADRC);
                    chart1.Series[2].Points.Add(SetPoint);
                    chart1.Series[3].Points.Add(SetPoint + 360);

                    chart2.Series[0].Points.Add(outputPID);
                    chart2.Series[1].Points.Add(outputADRC);

                    chart1.Series[0].Color = Color.DarkGreen;
                    chart1.Series[1].Color = Color.Red;
                    chart1.Series[2].Color = Color.Magenta;

                    chart2.Series[0].Color = Color.DarkGreen;
                    chart2.Series[1].Color = Color.Red;

                    Bitmap PID = BitmapModifier.RotateImage(new Bitmap(Path.GetFullPath(@"..\..\PID.png")), (float)anglePID + 180f);
                    Bitmap ADRC = BitmapModifier.RotateImage(new Bitmap(Path.GetFullPath(@"..\..\ADRC.png")), (float)angleADRC + 180f);

                    pictureBox1.Image = BitmapModifier.CombineImages(PID, ADRC);
                }));
            }
        }

        /// <summary>
        /// Calculates the fourier transforms and updates the axis scales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_CalculateFourierTransforms(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            
            float[] pidFFTW = FourierTransform.CalculateFFTW(PIDOutput.ToArray());
            float[] adrcFFTW = FourierTransform.CalculateFFTW(ADRCOutput.ToArray());

            float[] pidAngleFFTW = FourierTransform.CalculateFFTW(PIDAngle.ToArray());
            float[] adrcAngleFFTW = FourierTransform.CalculateFFTW(ADRCAngle.ToArray());

            this.BeginInvoke((Action)(() =>
            {
                double pidMax, adrcMax;
                
                pidMax = pidMaxValue.Filter((pidFFTW.Max() + Math.Abs(pidFFTW.Min())) / 2);
                adrcMax = adrcMaxValue.Filter((adrcFFTW.Max() + Math.Abs(adrcFFTW.Min())) / 2);

                pidScale.Text = "PID Scale: " + pidMax;
                adrcScale.Text = "ADRC Scale: " + adrcMax;

                chart3.ChartAreas[0].AxisY.Maximum = pidMax;
                chart3.ChartAreas[0].AxisY.Minimum = -pidMax;

                chart4.ChartAreas[0].AxisY.Maximum = adrcMax;
                chart4.ChartAreas[0].AxisY.Minimum = -adrcMax;
            }));

            e.Result = new float[4][] { pidFFTW, adrcFFTW, pidAngleFFTW, adrcAngleFFTW };
        }

        /// <summary>
        /// Updates the fourier transform charts and the 2d memory displays.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_ChangeFourierTransforms(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (float freq in ((float[][])(e.Result))[0])
            {
                chart3.Series[0].Points.Add(freq);
            }

            foreach (float freq in ((float[][])(e.Result))[1])
            {
                chart4.Series[0].Points.Add(freq);
            }

            foreach (float freq in ((float[][])(e.Result))[2])
            {
                chart3.Series[1].Points.Add(freq);
            }

            foreach (float freq in ((float[][])(e.Result))[3])
            {
                chart4.Series[1].Points.Add(freq);
            }

            double pidFFTWStdDev = MathFunctions.CalculateStdDev(Array.ConvertAll(((float[][])(e.Result))[0], x => (double)x).AsEnumerable());
            double adrcFFTWStdDev = MathFunctions.CalculateStdDev(Array.ConvertAll(((float[][])(e.Result))[1], x => (double)x).AsEnumerable());
            
            if (pidFFTWStdDev > FourierTolerance)
            {
                PIDFourierBitmap.SetMaxOutput((float)pidMaxValue.GetFilteredValue());
                pidPictureBox.Image = PIDFourierBitmap.Calculate2DFourierTransform(((float[][])(e.Result))[0]);
            }

            if (adrcFFTWStdDev > FourierTolerance)
            {
                ADRCFourierBitmap.SetMaxOutput((float)adrcMaxValue.GetFilteredValue());
                adrcPictureBox.Image = ADRCFourierBitmap.Calculate2DFourierTransform(((float[][])(e.Result))[1]);
            }
        }

        private void Visualizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1.Stop();
            t2.Stop();
            t3.Stop();
        }
    }
}
