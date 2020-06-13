using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int counter = 1;
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], counter);
                }
                else
                {
                    dict[input[i]]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
