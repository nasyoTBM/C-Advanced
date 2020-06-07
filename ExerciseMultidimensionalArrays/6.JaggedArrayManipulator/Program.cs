using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                double[] rows = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArr[i] = rows;

            }
            for (int i = 0; i < n - 1; i++)
            {
                if (jaggedArr[i].Count() == jaggedArr[i + 1].Count())
                {
                    jaggedArr[i] = jaggedArr[i].Select(x => x * 2).ToArray();
                    jaggedArr[i + 1] = jaggedArr[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArr[i] = jaggedArr[i].Select(x => x / 2).ToArray();
                    jaggedArr[i + 1] = jaggedArr[i + 1].Select(x => x / 2).ToArray();
                }
            }

            string input = Console.ReadLine();


            while (input.ToLower() != "end")
            {
                string[] command = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                int row = -1;
                int col = -1;
                bool testRow = int.TryParse(command[1], out row);
                bool testCol = int.TryParse(command[2], out col);
                double value = double.Parse(command[3]);

                if (row >= 0 && row < n)
                {

                    if (col >= jaggedArr[row].Length || col < 0)
                    {

                    }
                    else if (command[0] == "Add")
                    {
                        jaggedArr[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedArr[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArr[i]));
            }
        }
    }
}
