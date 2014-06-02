using Kalk.Intefaces;

namespace Kalk.BinaryFuctions
{
    public class Adder : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result;
            result = first + second;
            return result;
        }
    }
}

