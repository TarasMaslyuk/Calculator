using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
{
    public class Sqrt: IUnitOperation
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Sqrt(first);
            return result;

        }
    }
}
