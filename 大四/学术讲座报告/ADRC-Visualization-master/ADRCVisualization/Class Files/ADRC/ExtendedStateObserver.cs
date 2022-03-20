using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    //ESO
    class ExtendedStateObserver
    {
        /*
            //INPUTS: b0/u, y
            //OUTPUTS: Z1, Z2, Z3
            // An augmented variable Formula is introduced to a 2-order system. 
            // Using z1, z2, and z3 to estimate x1, x2, and x3, respectively,
            // an extended state observer is designed as:
            // http://ieeexplore.ieee.org/xpls/icp.jsp?arnumber=7334962#references
            
            //Total Disturbance Estimation and Rejection via ESO
            
            //where β01, β02, and β03 are observer gains

            e = z1 − y
            fe = fal(e, 0.5, δ)
            fe1 = fal(e, 0.25, δ)

            z1(k + 1) = z1(k) + h ∗ (z2(k) − β01 ∗ e)
            z2(k + 1) = z2(k) + h ∗ (z3(k) − β02 ∗ fe) + b0 * u
            z3(k + 1) = z3(k) + h ∗ (−β03 ∗ fe1)

            fal(e, α, δ) = {
                e / (δ * α − 1),                         |e| <= δ
                pow(abs(e), α) * sign(e),                |e| >  δ
                
        */
        private double z1 = 0;//Maintains previous state
        private double z2 = 0;
        private double z3 = 0;
        private double gain1;//State 
        private double gain2;
        private double gain3;
        private bool linear;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="samplingPeriod">Sampling frequency</param>
        /// <param name="linear">Determines whether using linear or non linear gains</param>
        public ExtendedStateObserver(bool linear)
        {
            this.linear = linear;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="samplingPeriod"></param>
        /// <param name="u"></param>
        /// <param name="b0"></param>
        /// <param name="processVariable"></param>
        /// <returns></returns>
        public Tuple<double, double, double> ObserveState(double samplingPeriod, double u, double b0, double processVariable)
        {
            if (linear)
            {
                //Linear gains
                gain1 = 1;
                gain2 = 1 / (3 * samplingPeriod);
                gain3 = 2 / (Math.Pow(8, 2) * Math.Pow(samplingPeriod, 2));
            }
            else
            {
                //Nonlinear gains
                gain1 = 1;
                gain2 = 1 / (2 * Math.Pow(samplingPeriod, 0.5));
                gain3 = 2 / (Math.Pow(5, 2) * Math.Pow(samplingPeriod, 1.2));
            }

            double e, fe, fe1;

            //e = z1 − y
            //fe = fal(e, 0.5, δ)
            //fe1 = fal(e, 0.25, δ)
            
            e = z1 - processVariable;//pv = y
            fe = NonLinearFunction(e, 0.5, samplingPeriod);//3rd parameter as sampling period as shown in 
            fe1 = NonLinearFunction(e, 0.25, samplingPeriod);//From PID to Active Disturbance Rejection Control by Jingqing Han

            //z1(k + 1) = z1(k) + h ∗ (z2(k) − β01 ∗ e)
            //z2(k + 1) = z2(k) + h ∗ (z3(k) − β02 ∗ fe) + b0 * u
            //z3(k + 1) = z3(k) + h ∗ (−β03 ∗ fe1)

            z1 = z1 + (samplingPeriod * z2) - (gain1 * e);
            z2 = z2 + (samplingPeriod * (z3 + (b0 * u))) - (gain2 * fe);
            z3 = z3 - (gain3 * fe1);

            return new Tuple<double, double, double>(z1, z2, z3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eta"></param>
        /// <param name="alpha"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        private double NonLinearFunction(double eta, double alpha, double delta)//fal
        {
            //e / (δ ^ α − 1),                         | e | <= δ
            //pow(abs(e), α) * sign(e),                | e | >= δ

            if (Math.Abs(eta) <= delta)
            {
                return eta / (Math.Pow(delta, 1 - alpha));
            }
            else
            {
                return Math.Pow(Math.Abs(eta), alpha) * Math.Sign(eta);
            }
        }
    }
}
