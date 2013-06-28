using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    class ToY:BinaryOperation
    {
        public override double Calculate(double arg1, double arg2)
        {
            arg2 = Math.Sin(arg2);
            return arg1 * arg2;
        }
    }
}
