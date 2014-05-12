namespace Kalk
{
    public class Multuplication : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result;
            result = first*second;
            return result;
        }
    }
} 
