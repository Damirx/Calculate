using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    class Logarifm_10:Operation
    {
        public override double Calculate(double arg1)
        {
            return Math.Log10(arg1);
        }
    }
}
