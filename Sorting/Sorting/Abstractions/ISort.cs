using System.Collections.Generic;

namespace Sorting.Abstractions
{
    public interface ISort
    {
        IEnumerable<int> Sort(IEnumerable<int> inputCollection);
    }
}
