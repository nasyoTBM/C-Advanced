using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedSet<string> table = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int k = 0; k < input.Length; k++)
                {
                    table.Add(input[k]);
                }
            }
            Console.WriteLine(string.Join(" ",table));
        }
    }
}
