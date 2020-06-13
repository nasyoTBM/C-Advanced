using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> solution = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!solution.ContainsKey(input[i]))
                {
                    solution.Add(input[i], 1);
                }
                else
                {
                    solution[input[i]]++;
                }
            }
            foreach (var item in solution.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s ");
            }
        }
    }
}
