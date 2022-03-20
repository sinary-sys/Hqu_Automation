using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    class ADRC_PD
    {
        private PID pid;
        private ExtendedStateObserver ExtendedStateObserver;
        private NonlinearCombiner NonlinearCombiner;

        private DateTime dateTime;

        private double amplificationCoefficient;
        private double dampingCoefficient;
        private double precisionCoefficient;//0.2
        private double samplingPeriod;//0.05
        private double plantCoefficient;//b0 approximation
        private double precisionModifier;
        private double maxOutput;
        private double previousPD;
        private double output;

        /// <summary>
        /// ADRC implementation utilizing a PD controller in place of a tracking differentiator.
        /// </summary>
        /// <param name="amplificationCoefficient">R</param>
        /// <param name="dampingCoefficient">C</param>
        /// <param name="plantCoefficient">B</param>
        /// <param name="precisionModifier">H0</param>
        /// <param name="kp">P Gain</param>
        /// <param name="kd">D Gain</param>
        /// <param name="maxOutput">Constrained maximum output</param>
        public ADRC_PD(double amplificationCoefficient, double dampingCoefficient, double plantCoefficient, double precisionModifier, double kp, double kd, double maxOutput)
        {
            this.amplificationCoefficient = amplificationCoefficient;
            this.dampingCoefficient = dampingCoefficient;
            this.plantCoefficient = plantCoefficient;
            this.precisionModifier = precisionModifier;
            this.maxOutput = maxOutput;

            pid = new PID(kp, 0, kd, maxOutput);
            ExtendedStateObserver = new ExtendedStateObserver(false);
            NonlinearCombiner = new NonlinearCombiner(amplificationCoefficient, dampingCoefficient);

            dateTime = DateTime.Now;
        }

        /// <summary>
        /// Calculates the output given the target value and actual value.
        /// </summary>
        /// <param name="setpoint">Target</param>
        /// <param name="processVariable">Actual</param>
        /// <returns></returns>
        public double Calculate(double setpoint, double processVariable)
        {
            samplingPeriod = DateTime.Now.Subtract(dateTime).TotalSeconds;

            if (samplingPeriod > 0)
            {
                precisionCoefficient = samplingPeriod * precisionModifier;
                
                double pdValue = pid.Calculate(setpoint, processVariable, samplingPeriod);

                Tuple<double, double> pd = new Tuple<double, double>(pdValue, previousPD);
                Tuple<double, double, double> eso = ExtendedStateObserver.ObserveState(samplingPeriod, output, plantCoefficient, processVariable);//double u, double y, double b0

                output = NonlinearCombiner.Combine(pd, plantCoefficient, eso, precisionCoefficient);

                previousPD = pdValue;
                dateTime = DateTime.Now;
            }

            return MathFunctions.Constrain(output, -maxOutput, maxOutput);
        }
    }
}
