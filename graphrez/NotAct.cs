﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class NotAct:Operation
    {
        public override double Calculate(double arg1, double arg2)
        {
            return arg1;
        }
    }
}
