﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Sqrt: IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Sqrt(first);
            return result;

        }
    }
}