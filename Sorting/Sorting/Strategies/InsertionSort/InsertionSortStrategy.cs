using System.Collections.Generic;
using System.Linq;
using Sorting.Abstractions;

namespace Sorting.Strategies.InsertionSort
{
    public class InsertionSortStrategy : ISort
    {
        public IEnumerable<int> Sort(IEnumerable<int> inputCollection)
        {
            var result = inputCollection.ToArray();

            //result.Length
            for (var i = 0; i < result.Length; i++)
            {
                var j = i;
                while (j > 0 && (result[j - 1] > result[j]))
                {

                    var temp = result[j - 1];
                    result[j - 1] = result[j];
                    result[j] = temp;

                    j--;
                }
            }


            return result;
        }
    }
}
