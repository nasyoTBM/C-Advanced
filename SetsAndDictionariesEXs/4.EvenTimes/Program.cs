using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> list = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (list.ContainsKey(number))
                {
                    list[number]++;
                }
                else
                {
                    list.Add(number, 1);
                }
            }
            foreach (var item in list)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
    

