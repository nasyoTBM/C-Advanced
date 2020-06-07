using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            

            for (int row = 0; row < n; row++)
            {
                char[] rows = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isPresent = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col]==symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isPresent = true;
                        return;
                    }
                }
            }
            if (!isPresent)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
