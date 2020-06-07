using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = input[0];
            int toRemove = input[1];
            int lookFor = input[2];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < count; i++)
            {
                que.Enqueue(numbers[i]);
            }
            for (int i = 0; i < toRemove; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(lookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (que.Count!=0)
                {
                    Console.WriteLine(que.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
