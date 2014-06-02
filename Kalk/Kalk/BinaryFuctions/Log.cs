using System;
using Kalk.Intefaces;

namespace Kalk.BinaryFuctions
{
    public class Log : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            if (first < 0 || first == 1 || second<0)
            {
                throw new Exception("Argument is not in the acceptable range!");
            }
            double result;
            result = Math.Log(first, second);
            return result;

        }
    }
}
