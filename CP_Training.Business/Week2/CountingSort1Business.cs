using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.Business.Week2
{
    public class CountingSort1Business
    {
        public List<int> CountingSort(List<int> arr)
        {
            int[] result = new int[100];

            foreach(int currentNumber in arr)
            {
                result[currentNumber]++;
            }

            return result.ToList();
        }
    }
}
