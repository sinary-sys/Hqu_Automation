using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    //nonlinear TD
    class TrackingDifferentiator : AbstractMath
    {
        /*
            //INPUTS: v(v0)
            //OUTPUTS: v1, v2
            // A nonlinear TD is constructed based on the fact that the numerical 
            // integration provides more stable and accurate results than numerical 
            // differentiation in the presence of noise 
            // [http://ieeexplore.ieee.org/xpls/icp.jsp?arnumber=7334962#deqn4]

            // v0 denotes the control objective
            // r0 and h0 are positive parameters
            // h is sampling time

            fh = fhan(v1−ν0, v2, r0, h0);
            
            v1(k + 1) = v1(k) + h ∗ v2; // transition signal
            v2(k + 1) = v2(k) + h ∗ fh; // derivative of v1

        
        */
        private double v1;
        private double v2;
        private double amplificationCoefficient;//r

        public TrackingDifferentiator(double amplificationCoefficient)
        {
            this.amplificationCoefficient = amplificationCoefficient;
        }

        public Tuple<double, double> Track(double input, double samplingPeriod)
        {
            double fh = SetPointJumpPrevention(v1 - input, v2, amplificationCoefficient, samplingPeriod);

            v1 = v1 + samplingPeriod * v2;// transition signal
            v2 = v2 + samplingPeriod * fh;// derivative of transtion signal

            return new Tuple<double, double>(v1, v2);
        }
    }
}
