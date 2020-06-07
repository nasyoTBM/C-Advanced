using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int current = queue.Peek();
                queue.Dequeue();
                if (current % 2 == 0)
                { 
                    queue.Enqueue(current);
                }
                
            }
            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
