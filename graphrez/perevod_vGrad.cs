using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class perevod_vGrad : Operation
    {
        public override double Calculate(double arg1, double arg2)
        {
            return (arg1*3.14/180);
        }

    }
}
