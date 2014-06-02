using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
{
    public class Log10 : IUnitOperation
    {
        public double Calculate(double first)
        {
            if (first <0 || first==1)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Log10(first);
            return result;

        }
    }
}
