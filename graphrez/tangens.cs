using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
   public class tangens : Operation
    {
       public override double Calculate(double arg1, double arg2)
        {
            return (Math.Tan(arg1));
        }
    }
}
