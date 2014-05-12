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
                case "Exp":
                    return new Exp();
                case "Sin": 
                    return new Sin();
                case "Ctg":
                    return new Ctg();
                default: 
                    throw new ArgumentException("Неизвесный калькулятор","name");
            }
        }
    }
}