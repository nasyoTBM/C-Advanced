using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            int maxSum = int.MinValue;
            int bestSumRow = int.MinValue;
            int bestSumCol = int.MinValue;
            
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    int[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = input[cols];
                    }
                }
                for (int i = 0; i < matrix.GetLength(0) - 2; i++)
                {
                    int currentSum = 0;

                    for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                    {
                        currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                            + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                            + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];


                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            bestSumRow = i;
                            bestSumCol = j;
                        }
                    }

                }
                Console.WriteLine($"Sum = {maxSum}");
                for (int i = bestSumRow; i < bestSumRow + 3; i++)
                {
                    for (int j = bestSumCol; j < bestSumCol + 3; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            
            
        }
    }
}
