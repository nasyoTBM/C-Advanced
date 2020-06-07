using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long[][] jaggedArr = new long[long.Parse(Console.ReadLine())][];
            int currentLength = 1;
            
            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArr[i] = new long[currentLength];
                jaggedArr[i][0] = 1;
                jaggedArr[i][currentLength - 1] = 1;

                if (currentLength > 2)
                {
                    for (int j = 1; j < currentLength-1; j++)
                    {
                        jaggedArr[i][j] = jaggedArr[i - 1][j-1] + jaggedArr[i - 1][j];
                    }
                }
                currentLength++;
            }

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ",jaggedArr[i]));
            }
        }
    }
}
