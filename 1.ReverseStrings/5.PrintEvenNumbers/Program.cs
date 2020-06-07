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
            Queue<int> input = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int n = input.Count();
            for (int i = 0; i < n; i++)
            {
                int current = input.Peek();
                if (current%2!=0)
                {
                    input.Dequeue();
                }
                else
                {
                    input.Dequeue();
                    input.Enqueue(current);
                }
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
