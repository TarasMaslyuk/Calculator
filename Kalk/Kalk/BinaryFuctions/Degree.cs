using System;
using Kalk.Intefaces;

namespace Kalk.BinaryFuctions
{
    public class Degree : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result;
            result = Math.Pow(first,second);
            return result;

        }
    }
}
