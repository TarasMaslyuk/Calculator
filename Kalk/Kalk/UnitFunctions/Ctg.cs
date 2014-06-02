using System;
using Kalk.Intefaces;

namespace Kalk.UnitFunctions
{
    public class Ctg : IUnitOperation
    {
        public double Calculate(double first)
        {
            if (first==-Math.PI || first==Math.PI)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Cos(first )/Math.Sin(first );
            return result;

        }
    }
}
