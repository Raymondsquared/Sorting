using System;
using System.Collections.Generic;
using Sorting.Abstractions;
using Sorting.Strategies.BubbleSort;
using Sorting.Strategies.InsertionSort;

namespace Sorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            foreach (var sortingStrategy in GetSortingStrategies())
            {
                var problem = new int[] {100, 10, 50, 90, 80, 30, 70};

                Console.WriteLine($"{Environment.NewLine}");
                Console.WriteLine($"Problem : {string.Join(",", problem)}");
                Console.WriteLine($"Solution : {string.Join(",", sortingStrategy.Sort(problem))}");
                Console.WriteLine($"---------------------------------------------------------------------");                
            }
        }

        public static IList<ISort> GetSortingStrategies()
        {
            var result = new List<ISort>()
            {
                new BubbleSortStrategy(),
                new InsertionSortStrategy()
            };

            return result;
        }
    }
}
