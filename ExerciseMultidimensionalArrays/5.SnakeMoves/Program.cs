using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            string snake = Console.ReadLine();
            int currentCol = 0;
            int currentRow = 0;
            int counter = 0;
           
            while (counter != matrix.Length)
            {

                for (int i = 0; i < snake.Length; i++)
                {
                    

                    if (currentCol == matrix.GetLength(1) || currentCol == -1)
                    {
                        currentRow++;
                        if (currentRow % 2 == 0)
                        {
                            currentCol++;
                        }
                        else
                        {
                            currentCol--;
                        }

                    }
                    matrix[currentRow, currentCol] = snake[i];
                    counter++;
                    

                    if (currentRow % 2 == 0)
                    {
                        currentCol++;
                    }
                    else
                    {
                        currentCol--;
                    }
                    if (counter == matrix.Length)
                    {
                        break;
                    }


                }
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }


        }
    }
}
