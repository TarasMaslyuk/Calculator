using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Sin : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result;
            result = Math.Sin(first + second);
            return result;

        }
    }
}
