using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] condition = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int toPush = condition[0];
            int toPop = condition[1];
            int toLookFor = condition[2];
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < toPush; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            if (!stack.Contains(toLookFor)&&stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (!stack.Contains(toLookFor))
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("true");
            }

        }
    }
}
