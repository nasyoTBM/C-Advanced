using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                jaggedArr[i] = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                
            }
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] action = input.Split(' ').ToArray();
                string command = action[0];
                int arrayNumber = int.Parse(action[1]);
                int arrayNumberMember = int.Parse(action[2]);
                int number = int.Parse(action[3]);

                if (arrayNumber < 0 || arrayNumber > n-1)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (arrayNumberMember < 0 || arrayNumberMember > jaggedArr[arrayNumber].Length-1)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if ((command.ToLower() == "add"))
                    {
                        jaggedArr[arrayNumber][arrayNumberMember] += number;
                    }
                    else if (command.ToLower() == "subtract")
                    {
                        jaggedArr[arrayNumber][arrayNumberMember] -= number;
                    }
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ",jaggedArr[i]));
            }
        }
    }
}
