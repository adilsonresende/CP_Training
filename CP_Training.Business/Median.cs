using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class Median
    {
        public int FindMedian(List<int> arr)
        {
            int middle = (arr.Count - 1) / 2;
            arr = arr.OrderBy(x => x).ToList();
            int result = arr[middle];
            return result;
        }
    }
}
