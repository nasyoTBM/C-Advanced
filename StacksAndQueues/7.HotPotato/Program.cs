using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queue = new Queue<string>(input);
            int passes = int.Parse(Console.ReadLine());
            while (queue.Count>1)
            {
                for (int i = 1; i < passes; i++)
                {
                    string current = queue.Dequeue();
                    queue.Enqueue(current);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
