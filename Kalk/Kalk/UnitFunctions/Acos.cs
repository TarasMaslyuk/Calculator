using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
{
    public class Acos : IUnitOperation
    {
        public double Calculate(double first)
        {
            if (first < -1 || first > 1)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Acos(first);
            return result;

        }
    }
}
