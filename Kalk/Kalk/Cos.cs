using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Cos: IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Cos(first);
            return result;

        }
    }
}
