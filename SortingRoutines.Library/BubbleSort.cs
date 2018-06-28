namespace SortingRoutines.Library
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class BubbleSort : ISorter
    {
        public List<int> Sort(List<int> values)
        {
            var data = values.ToArray();

            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                bool swapsInThisIteration = false;

                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        swapsInThisIteration = true;
                        Swap(ref data, i, i + 1);
                    }
                }

                if (!swapsInThisIteration)
                {
                    break;
                }
            }

            return new List<int>(data);
        }

        private static void Swap(ref int[] data, int x, int y)
        {
            var temp = data[x];
            data[x] = data[y];
            data[y] = temp;
        }
    }
}
