using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class ConvertToRad : Operation
    {
        public override double Calculate(double arg1)
        {
            return (arg1*3.14/180);
        }

    }
}
