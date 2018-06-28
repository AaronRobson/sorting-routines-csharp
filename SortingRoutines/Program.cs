namespace SortingRoutines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SortingRoutines.Library;

    class Program
    {
        private static readonly List<int> Given = new List<int> { 3, 2, 4, 1 };

        private static string ListRepresentation<T>(List<T> values)
        {
            return string.Join(", ", values.Select(x => x.ToString()));
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Given:\n{ListRepresentation(Given)}\n");

            var bubbleSort = new BubbleSort();
            var Actual = bubbleSort.Sort(Given);
            Console.WriteLine($"Bubble Sort Result:\n{ListRepresentation(Actual)}\n");

            Console.WriteLine("Press any key to exit:");
            Console.Read();
        }
    }
}
