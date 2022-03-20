using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files.Solvers
{
    abstract class Solver
    {
        /*
            Required: Must be able to understand what function the parameter has.
            i.e. what the variable does to the output when it is changed

            This allows for solving a goal, for example: the std deviation over time 
            must be consistent, not slowly increasing or decreasing
            
            OR: Multi-Objective Optimization
        */
        public abstract void Solve();
    }
}