namespace Kalk.SortingOperations

{
    public class SortingAscending : ISortingOperation
    {
        public int[] Sort(int[] array)
        {
            for (int nn = 0; nn < array.Length; nn++)
                for (int n = 0; n < array.Length-nn-1; n++)
                    if (array[n] < array[n+1])
                    {
                        int k = array[n + 1];
                        array[n + 1] = array[n];
                        array[n] = k;
                    }
            int[] result = array;
            return result;
        }
    }
}