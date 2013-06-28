using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class ConvertToGrad : Operation
    {
        public override double Calculate(double arg1)
        {
            return (arg1*180/3.14);
        }
    }
}
