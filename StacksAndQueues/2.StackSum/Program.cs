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
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0]!= "end")
            {
                string action = command[0].ToLower();
                


                switch (action)
                {
                    case "add": stack.Push(int.Parse(command[1]));
                                stack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        if (stack.Count<int.Parse(command[1]))
                        {
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                stack.Pop();
                            }
                            break;
                        }
                        
                    default:
                        throw new ArgumentException("Unknown Command");
                        break;
                        
                }
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                command[0] = command[0].ToLower();
            }
            while (stack.Count>1)
            {
                int elementOne = stack.Pop();
                int elementTwo = stack.Pop();
                stack.Push(elementOne + elementTwo);
            }
            Console.WriteLine($"Sum: {stack.Peek()}");
        }
    }
}
