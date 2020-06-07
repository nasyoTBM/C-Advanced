using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
