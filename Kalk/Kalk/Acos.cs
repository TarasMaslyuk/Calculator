using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Acos : IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Acos(first);
            return result;

        }
    }
}
