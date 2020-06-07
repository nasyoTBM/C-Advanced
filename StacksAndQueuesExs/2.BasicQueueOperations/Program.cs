using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conditions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int toAdd = conditions[0];
            int toRemove = conditions[1];
            int toFind = conditions[2];
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < toAdd; i++)
            {
                que.Enqueue(input[i]);
            }
            for (int i = 0; i < toRemove; i++)
            {
                que.Dequeue();
            }
            if (!que.Contains(toFind)&&que.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (!que.Contains(toFind))
            {
                Console.WriteLine(que.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
