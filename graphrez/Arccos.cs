using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Arccos : Operation
    {
        public override double Calculate(double arg1)
        {
            return (1/(Math.Cos(arg1)));
        }
    }
}
