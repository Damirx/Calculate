using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Sqr : Operation
    {
        public override double Calculate(double arg1)
        {
            return (Math.Pow(arg1, 2));
        }
    }
}