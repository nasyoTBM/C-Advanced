using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arr);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                switch (input[0])
                {
                    case "add":
                        int firstNum = int.Parse(input[1]);
                        int secondNum = int.Parse(input[2]);
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int n = int.Parse(input[1]);
                        if (n<=stack.Count)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                stack.Pop();
                            }
                        }
                        
                        break;
                    default: throw new AccessViolationException("Invalid command");
                        
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
