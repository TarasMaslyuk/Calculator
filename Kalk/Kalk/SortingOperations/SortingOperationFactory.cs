using System;

namespace Kalk
{
    public static class SortingOperationFactory
    {
        public static ISortingOperation CreateSortingOperation(string operationName)
        {
            switch (operationName)
            {
                case "Max":
                    return new SortingAscending();
                case "Min":
                    return new SortingDicending();
                default:
                    throw new ArgumentException("Неизвестная операция!", "operationName");
            }
        }
    }
}