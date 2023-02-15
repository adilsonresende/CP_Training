using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.Business.Week2
{
    public class CountingValleyBusiness
    {
        public int CountingValleys(int steps, string path)
        {
            int numberOfValleys = 0;
            int dept = 0;
            bool isInsideValley = false;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    dept++;
                }
                else
                {
                    dept--;
                }

                if (dept < 0 && !isInsideValley)
                {
                    numberOfValleys++;
                    isInsideValley = true;
                }

                if (dept >= 0 && isInsideValley)
                {
                    isInsideValley = false;
                }
            }

            return numberOfValleys;
        }
    }
}
