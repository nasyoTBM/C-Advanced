using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1BasicStackOperations
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
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < toRemove; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(lookFor))
            {
                Console.WriteLine("true");
            }
            else 
            {
                if (stack.Count!=0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
                
            }
        }
    }
}
