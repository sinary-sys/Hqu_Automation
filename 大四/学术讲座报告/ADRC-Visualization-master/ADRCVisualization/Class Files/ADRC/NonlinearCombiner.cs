using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    //NLC
    class NonlinearCombiner : AbstractMath
    {
        /*
            //INPUTS: e1, e2
            //OUTPUTS: u0

            // Nonlinear combination of errors and differential errors
            // where c, r, and h1 are positive parameters

            e1 = v1 − z1
            e2 = v2 − z2

            u0 = −fhan(e1, c * e2, r, h1)

            // Disturbance rejection
            // where b0 is a positive parameter

            u = u0 − z3 / b0

            
        */

        private double amplificationCoefficient;//r
        private double dampingCoefficient;//c

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amplificationCoefficient">Corresponds to the limit of acceleration.</param>
        /// <param name="dampingCoefficient">Damping coefficient to be adjusted in the neighborhood of unity.</param>
        public NonlinearCombiner(double amplificationCoefficient, double dampingCoefficient)
        {
            this.amplificationCoefficient = amplificationCoefficient;
            this.dampingCoefficient = dampingCoefficient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trajectory">v1,v2</param>
        /// <param name="b0">Estimate of coefficient b within +-50%</param>
        /// <param name="eso">Extended State Observer</param>
        /// <returns></returns>
        public double Combine(Tuple<double, double> td, double b0, Tuple<double, double, double> eso, double precisionCoefficient)
        {
            double e1, e2, u0;

            e1 = td.Item1 - eso.Item1;
            e2 = td.Item2 - eso.Item2;

            u0 = -SetPointJumpPrevention(e1, dampingCoefficient * e2, amplificationCoefficient, precisionCoefficient);

            //Contains disturbance rejection
            return (u0 + eso.Item3) / b0;// b0 must be positive
        }
    }
}
