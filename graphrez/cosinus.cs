using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Cosinus : Operation
    {
        public override double Calculate(double arg1)
        {
            return (Math.Cos(arg1));
        }

    }
}
