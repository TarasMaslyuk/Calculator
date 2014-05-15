using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Sin : IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Sin(first);
            return result;

        }
    }
}
