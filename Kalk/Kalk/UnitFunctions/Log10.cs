using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Log10 : IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Log10(first);
            return result;

        }
    }
}
