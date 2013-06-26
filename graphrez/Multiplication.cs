using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Multiplication : Operation
    {
        public override int Calculate(int arg1, int arg2)
        {
            return arg1 * arg2;
        }
    }
}

