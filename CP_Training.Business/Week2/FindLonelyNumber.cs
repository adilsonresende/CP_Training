using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class FindLonelyNumber
    {
        public int LonelyInteger(List<int> a)
        {
            int lonelyNumber = 0;
            for (int currentIndex = 0; currentIndex <= a.Count; currentIndex++)
            {
                lonelyNumber = a[currentIndex];
                List<int> tempList = new List<int>();
                tempList.AddRange(a);
                tempList.RemoveAt(currentIndex);

                bool isTheLonelyNumber = !tempList.Any(x => x == lonelyNumber);

                if (isTheLonelyNumber)
                {
                    break;
                }
            }

            return lonelyNumber;
        }
    }
}
