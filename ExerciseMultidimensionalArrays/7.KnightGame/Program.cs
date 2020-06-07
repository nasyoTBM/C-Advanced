using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int counter = 0;

            for (int rows = 0; rows < n; rows++)
            {
                char[] row = Console.ReadLine()
                    .ToCharArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = row[cols];
                }
            }
            while (true)
            {
                
                int maxCount = 0;
                int maxAttackedKnightsRow = -1;
                int maxAttackedKnightsCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char current = matrix[row, col];
                        if (current == 'K')
                        {
                            int currentCount = KnightAttackCount(matrix, row, col);

                            if (currentCount > maxCount)
                            {
                                maxCount = currentCount;
                                maxAttackedKnightsRow = row;
                                maxAttackedKnightsCol = col;
                            }
                        }
                    }
                }

                if (maxCount==0)
                {
                    break;
                }

                matrix[maxAttackedKnightsRow, maxAttackedKnightsCol] = '0';
                counter++;
            }
            Console.WriteLine(counter);
        }
        static int KnightAttackCount(char[,] matrix, int row, int col)
        {

            int counter = 0;

            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
            {

                counter++;
            }
            if (row - 2 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 2, col + 1] == 'K')
            {

                counter++;
            }
            if (row + 2 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
            {

                counter++;
            }
            if (row + 2 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 2, col + 1] == 'K')
            {

                counter++;
            }
            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
            {

                counter++;
            }
            if (row - 1 >= 0 && col + 2 < matrix.GetLength(1) && matrix[row - 1, col + 2] == 'K')
            {

                counter++;
            }
            if (row + 1 < matrix.GetLength(0) && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
            {

                counter++;
            }
            if (row + 1 < matrix.GetLength(0) && col + 2 < matrix.GetLength(1) && matrix[row + 1, col + 2] == 'K')
            {

                counter++;
            }
            return counter;

        }
    }

}
