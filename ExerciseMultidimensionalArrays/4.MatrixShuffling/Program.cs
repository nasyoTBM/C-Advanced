using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < dimensions[0]; rows++)
            {
                string[] row = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int cols = 0; cols < dimensions[1]; cols++)
                {
                    matrix[rows, cols] = row[cols];
                }
            }
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] command = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    if (row1<0||row1>matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else if (row2 < 0 || row2 > matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else if (col1 < 0 || col1 > matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else if (col2 < 0 || col2 > matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string current = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = current;
                        for (int rows = 0; rows < matrix.GetLength(0); rows++)
                        {
                            for (int cols = 0; cols < matrix.GetLength(1); cols++)
                            {
                                Console.Write(matrix[rows,cols] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                input = Console.ReadLine();

            }

        }
    }
}
