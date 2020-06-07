using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int lastCol = n - 1;
            for (int row = 0; row < n; row++)
            {
                int[] rows = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                    if (row == col)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                }
                secondaryDiagonalSum += matrix[row, lastCol];
                lastCol--;
            }

           
            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }
    }
}
