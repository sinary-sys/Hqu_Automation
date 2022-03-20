using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    class ADRC_TD//ActiveDisturbanceRejectionControl
    {
        private TrackingDifferentiator TrackingDifferentiator;
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

        private double output;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amplificationCoefficient"></param>
        /// <param name="dampingCoefficient"></param>
        /// <param name="plantCoefficient"></param>
        /// <param name="precisionModifier"></param>
        /// <param name="maxOutput"></param>
        public ADRC_TD(double amplificationCoefficient, double dampingCoefficient, double plantCoefficient, double precisionModifier, double maxOutput)
        {
            this.amplificationCoefficient = amplificationCoefficient;
            this.dampingCoefficient = dampingCoefficient;
            this.plantCoefficient = plantCoefficient;
            this.precisionModifier = precisionModifier;
            this.maxOutput = maxOutput;

            TrackingDifferentiator = new TrackingDifferentiator(amplificationCoefficient);
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
            //samplingPeriod = DateTime.Now.Subtract(dateTime).TotalSeconds + 0.08;

            samplingPeriod = 0.1;
            
            if (samplingPeriod > 0)
            {
                precisionCoefficient = samplingPeriod * precisionModifier;

                Tuple<double, double> td = TrackingDifferentiator.Track(setpoint, samplingPeriod);//double input
                Tuple<double, double, double> eso = ExtendedStateObserver.ObserveState(samplingPeriod, output, plantCoefficient, processVariable);//double u, double y, double b0

                output = NonlinearCombiner.Combine(td, plantCoefficient, eso, precisionCoefficient);

                dateTime = DateTime.Now;
            }

            return MathFunctions.Constrain(output, -maxOutput, maxOutput);
        }
    }
}
