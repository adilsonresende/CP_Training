using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class Matrixes
    {
        public int DiagonalDifference(List<List<int>> arr)
        {
            int numberOfColuns = arr[0].Count;
            int totalDiagonal = 0;
            int totalReversedDiagonal = 0;
            
            int currentColumn = 0;

            for(int currentRow = 0; currentRow < numberOfColuns; currentRow++)
            {
                totalDiagonal += (arr[currentRow][currentColumn]);
                currentColumn++;
            }

            currentColumn = numberOfColuns - 1;
            for (int currentRow = 0; currentRow < numberOfColuns; currentRow++)
            {
                totalReversedDiagonal +=(arr[currentRow][currentColumn]);
                currentColumn--;
            }

            return  Math.Abs(totalDiagonal - totalReversedDiagonal);
        }
    }
}
