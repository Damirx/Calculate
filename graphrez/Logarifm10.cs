﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
   public class Logarifm10:Operation
    {
        public override double Calculate(double arg1)
        {
            return Math.Log10(arg1);
        }
    }
}
