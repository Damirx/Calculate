using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    class Logy:BinaryOperation
    {
        public override double Calculate(double arg1, double arg2)
        {
            return Math.Log(arg1, arg2);
        }

    }
}
