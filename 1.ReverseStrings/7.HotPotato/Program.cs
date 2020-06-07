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
            Queue<string> que = new Queue<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
            int tosses = int.Parse(Console.ReadLine());
            while (que.Count>1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    string current = que.Dequeue();
                    que.Enqueue(current);
                }
                Console.WriteLine($"Removed {que.Dequeue()}");
            }
            Console.WriteLine($"Last is {que.Peek()}");
        }
    }
}
