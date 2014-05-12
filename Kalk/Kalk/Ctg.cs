using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Ctg : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result;
            result = Math.Cos(first + second)/Math.Sin(first + second);
            return result;

        }
    }
}
