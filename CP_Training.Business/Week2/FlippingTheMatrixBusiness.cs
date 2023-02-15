using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.Business.Week2
{
    public class FlippingTheMatrixBusiness
    {
        public int FlippingMatrix(List<List<int>> matrix)
        {
            int numberOfQuadrants = matrix.Count / 2;
            bool canHaveBiggerSum = true;
            int previousSum = 0;

            while (canHaveBiggerSum)
            {
                for (int row = 0; row < matrix.Count; row++)
                {

                    bool shouldSwapRow = (matrix[row].Take(numberOfQuadrants).Sum() < matrix[row].Skip(numberOfQuadrants).Take(numberOfQuadrants).Sum());
                    if (shouldSwapRow)
                    {
                        List<int> tempRow = new List<int>();
                        for (int i = matrix[row].Count - 1; i >= 0; i--)
                        {
                            tempRow.Add(matrix[row][i]);
                        }

                        matrix[row] = tempRow;
                    }
                }

                for (int row = 0; row < matrix.Count; row++)
                {
                    for (int column = 0; column < matrix[row].Count; column++)
                    {
                        List<int> colunmItens = new List<int>();
                        for(int i = 0; i < matrix[row].Count; i++)
                        {
                            colunmItens.Add(matrix[i][column]);
                        }

                        bool shouldSwap = colunmItens.Take(numberOfQuadrants).Sum() < colunmItens.Skip(numberOfQuadrants).Take(numberOfQuadrants).Sum();
                        List<int> tempColunm = new List<int>();
                        if (shouldSwap)
                        {
                            for(int i = colunmItens.Count -1; i >= 0; i--)
                            {
                                tempColunm.Add(colunmItens[i]);
                            }

                            for(int i = 0; i < matrix[row].Count; i++)
                            {
                                matrix[i][column] = tempColunm[i];
                            }
                        }
                    }
                }

                int currentSum = 0;
                for(int row = 0; row < numberOfQuadrants; row++)
                {
                    for(int colunm = 0; colunm < numberOfQuadrants; colunm++)
                    {
                        currentSum += matrix[row][colunm];
                    }
                }

                if(currentSum > previousSum)
                {
                    previousSum = currentSum;
                }
                else
                {
                    canHaveBiggerSum = false;
                }
            }

            return previousSum;
        }
    }
}
