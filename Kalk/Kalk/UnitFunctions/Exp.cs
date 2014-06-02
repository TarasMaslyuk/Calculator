using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
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
