using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class SumPairs
    {
        public int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            int sumPairCount = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j  < n; j++)
                {
                    bool isDivisible = (ar[i] + ar[j]) % k == 0;
                    sumPairCount += isDivisible ? 1 : 0;
                }
            }

            return sumPairCount;
        }
    }
}
