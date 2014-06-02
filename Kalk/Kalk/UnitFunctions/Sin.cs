using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
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
