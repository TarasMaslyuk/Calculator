using System;
using System.Collections;

namespace Kalk
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "Adder": 
                    return new Adder();
                case "Divider":
                    return  new Divider();
                case "Multuplication":
                    return new Multuplication();
                case "Substracter":
                    return new Substracter();
                case "Degree":
                    return new Degree();
                case"Log":
                    return new Log();
                default: 
                    throw new ArgumentException("Неизвесный калькулятор","name");
            }
        }
    }
}