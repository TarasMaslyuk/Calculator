using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    public class Exp: IUnitOperation
    {
        public double Calculate(double first)
        {
            double result;
            result = Math.Exp(first);
            return result;

        }
    }
}
