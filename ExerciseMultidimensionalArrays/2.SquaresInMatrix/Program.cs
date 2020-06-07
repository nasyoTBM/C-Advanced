using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            rows -= 1;
            cols -= 1;
            int counterEqualSquares = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i,j]== matrix[i,j+1] && matrix[i,j+1]==matrix[i+1,j] && matrix[i+1,j]==matrix[i+1,j+1])
                    {
                        counterEqualSquares++;
                    }
                }
            }
            Console.WriteLine(counterEqualSquares);
        }
    }
}
