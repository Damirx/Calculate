using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Exp : Operation
    {
        public override double Calculate(double arg1)
        {
            double e = 2.718281828;
            return Math.Pow(e, arg1);
        }
    }
}