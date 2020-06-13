using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstSet = lenghts[0];
            int secondSet = lenghts[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < firstSet; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < secondSet; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            first.IntersectWith(second);
            foreach (var item in first)
            {
                Console.Write(item+" ");
            }
        }
    }
}
