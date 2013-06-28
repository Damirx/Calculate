using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Arctang : Operation
    {
        public override double Calculate(double arg1)
        {
            return (1 / (Math.Tan(arg1)));
        }
    }
}
