using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    class ToX:BinaryOperation
    {
       public override double Calculate(double arg1, double arg2)
       {
           arg2=Math.Cos(arg2);
           return arg1*arg2;
       }
    }
}
