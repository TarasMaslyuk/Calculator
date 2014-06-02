using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
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
