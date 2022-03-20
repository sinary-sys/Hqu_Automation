using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    class PID
    {
        private double maxOutput;
        private double kp;
        private double ki;
        private double kd;
        private double integral;
        private double error;
        private double previousError;
        private double output;
        private DateTime time;

        /// <summary>
        /// Initializes the PID.
        /// </summary>
        /// <param name="kp">Proportional gain</param>
        /// <param name="ki">Integral gain</param>
        /// <param name="kd">Derivative gain</param>
        /// <param name="maxOutput">Maximum output for constraint</param>
        public PID(double kp, double ki, double kd, double maxOutput)
        {
            this.kp = kp;
            this.ki = ki;
            this.kd = kd;
            this.maxOutput = maxOutput;

            time = DateTime.Now;
        }

        /// <summary>
        /// Calculates the setpoint with an automatically set sampling period.
        /// </summary>
        /// <param name="setpoint">Target</param>
        /// <param name="processVariable">Actual</param>
        /// <returns>Returns output of PID</returns>
        public double Calculate(double setpoint, double processVariable)
        {
            double POut, IOut, DOut, dt;
            
            DateTime currentTime = DateTime.Now;
            dt = currentTime.Subtract(time).TotalSeconds;

            if (dt > 0)
            {
                error = setpoint - processVariable;

                POut = kp * error;

                integral += error * dt;
                IOut = ki * integral;

                DOut = kd * ((error - previousError) / dt);

                output = MathFunctions.Constrain(POut + IOut + DOut, -maxOutput, maxOutput);

                time = currentTime;
                previousError = error;
            }

            return output;
        }

        /// <summary>
        /// Calculates the setpoint with a custom sampling period.
        /// </summary>
        /// <param name="setpoint">Target</param>
        /// <param name="processVariable">Actual</param>
        /// <param name="samplingPeriod">Period between calculations</param>
        /// <returns>Returns output of PID</returns>
        public double Calculate(double setpoint, double processVariable, double samplingPeriod)
        {
            double POut, IOut, DOut;

            if (samplingPeriod > 0)
            {
                error = setpoint - processVariable;

                POut = kp * error;

                integral += error * samplingPeriod;
                IOut = ki * integral;

                DOut = kd * ((error - previousError) / samplingPeriod);

                output = MathFunctions.Constrain(POut + IOut + DOut, -maxOutput, maxOutput);
                
                previousError = error;
            }

            return output;
        }
    }
}
