using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
   public class NaturalLogarifm:Operation
    {
        public override double Calculate(double arg1)
        {
            return Math.Log(arg1);
        }
    }
}
