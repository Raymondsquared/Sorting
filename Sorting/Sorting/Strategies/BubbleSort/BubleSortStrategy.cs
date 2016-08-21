using System;
using System.Collections.Generic;
using System.Linq;
using Sorting.Abstractions;

namespace Sorting.Strategies.BubbleSort
{
    public class BubbleSortStrategy : ISort
    {
        public IEnumerable<int> Sort(IEnumerable<int> inputCollection)
        {
            var result = inputCollection.ToArray();

            bool swapped;

            do
            {
                swapped = false;

                for (var i = 1; i < result.Length; i++)
                {
                    if (result[i - 1] > result[i])
                    {
                        var temp = result[i - 1];
                        result[i - 1] = result[i];
                        result[i] = temp;

                        swapped = true;
                    }
                }

            } while (swapped);



            return result;
        }
    }
}
