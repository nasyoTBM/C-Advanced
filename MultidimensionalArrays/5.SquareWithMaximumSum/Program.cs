using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < rows; row++)
            {
                int[] matrixRows = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixRows[col];

                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < cols - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumRow = row;
                        maxSumCol = col;

                    }
                }
            }
            Console.WriteLine(matrix[maxSumRow, maxSumCol] + " " + matrix[maxSumRow, maxSumCol + 1]);
            Console.WriteLine(matrix[maxSumRow + 1, maxSumCol] + " " + matrix[maxSumRow + 1, maxSumCol + 1]);
            Console.WriteLine(maxSum);

        }
    }
}
