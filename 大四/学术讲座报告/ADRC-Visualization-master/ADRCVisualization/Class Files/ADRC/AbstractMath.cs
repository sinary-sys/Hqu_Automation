using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    abstract class AbstractMath
    {
        /*
            // fhan function is denoted below
            d = r * h
            d0 = h * d
            y = x1 + h * x2

            a0 = sqrt(d2 + 8 * r * abs(y))

            a = {
                x2 + (a0−d) / 2 * sign(y),  if abs(y) > d0
                xx2 + yh,                   if abs(y) <= d0

            fhan = {
                −r * sign(a),               if abs(a) > d
                -r * a / d,                 if abs(a) <= d

        */

        //
        public double SetPointJumpPrevention(double target, double targetDerivative, double r0, double h)//Get actual name of function,  setpoint jump prevention
        {
            double d, a, a0, a1, a2, y, sy, sa;

            d = Math.Pow(r0, 2) * h;
            a0 = h * targetDerivative;
            y = target + a0;

            a1 = Math.Sqrt(d * (d + 8 * Math.Abs(y)));
            a2 = a0 + Math.Sign(y) * (a1 - d) / 2;
            sy = (Math.Sign(y + d) - Math.Sign(y - d)) / 2;//returns 1, or -1

            a = (a0 + y - a2) * sy + a2;
            sa = (Math.Sign(a + d) - Math.Sign(a - d)) / 2;//returns 1, or -1

            return -r0 * ((a / d) - Math.Sign(a)) * sa - r0 * Math.Sign(a);
        }
    }
}
