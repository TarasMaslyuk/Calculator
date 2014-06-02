using System;
using Kalk.Intefaces;
using Kalk.UnitFunctions;

namespace Kalk.Factories
{
    public static class UnitOperationFactory
    {
        public static IUnitOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "Exp":
                    return new Exp();
                case "Sin":
                    return new Sin();
                case "Ctg":
                    return new Ctg();
                case "Acos":
                    return new Acos();
                case "Sqrt":
                    return new Sqrt();
                case "Log10":
                    return new Log10();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "Asin":
                    return new Asin();
                case"Atg":
                    return new Atg();
                default:throw new ArgumentException("Неизвесный калькулятор", "name");
            }
        }
    }
}
