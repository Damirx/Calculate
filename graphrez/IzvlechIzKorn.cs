using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class IzvlechIzKorn : BinaryOperation
    {
        public override double Calculate(double arg1, double arg2)
        {
            return (Math.Pow(arg1, 1 / arg2));
        }
    }
}

