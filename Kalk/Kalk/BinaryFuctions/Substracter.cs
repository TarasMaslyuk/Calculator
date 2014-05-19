using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Substracter : IBinaryOperation
    {
       public double Calculate(double first, double second)
        {
            double result;
            result = first - second;
            return result;
        }
    }
}
