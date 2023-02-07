using System.Collections.Generic;

namespace CP_Training.Business
{
    public class Grades
    {
        public List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            const int nextMultipleToRound = 5;
            const int maximumDifferenceAllowed = 2;
            foreach (int i in grades)
            {
                if (i % nextMultipleToRound == 0)
                {
                    result.Add(i);
                    continue;
                }
                else
                {
                    int tempNumber = i;
                    int difference = 0;
                    while (tempNumber % nextMultipleToRound != 0)
                    {
                        tempNumber++;
                        difference++;
                    }

                    bool shouldRound = difference <= maximumDifferenceAllowed && tempNumber >= 40;
                    if (shouldRound)
                    {
                        result.Add(tempNumber);
                    }
                    else
                    {
                        result.Add(i);
                    }
                }
            }

            return result;
        }
    }
}
