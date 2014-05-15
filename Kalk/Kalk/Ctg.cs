using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Ctg : IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Cos(first )/Math.Sin(first );
            return result;

        }
    }
}
