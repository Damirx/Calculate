using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class logarifm_e:Operation
    {
        public override double Calculate(double arg1)
        {
            return Math.Log(arg1);
        }
    }
}
