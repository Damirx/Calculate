using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Factorial : Operation
    {
        public override double Calculate(double arg1)
        {
           if (arg1==1)
            {
                return (1);
            }
            else
            {
                return arg1=arg1*Calculate(arg1 - 1);
            }
            return (arg1);
        }
    }
}