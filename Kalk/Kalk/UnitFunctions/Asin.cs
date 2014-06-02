using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
{
    public class Asin : IUnitOperation
    {
        public double Calculate(double first)
        {
            if (first < -Math.PI/2 || first > Math.PI)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Asin(first);
            return result;

        }
    }
}
