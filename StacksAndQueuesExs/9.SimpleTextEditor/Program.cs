using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            string ex = string.Empty;
            int commandsCount = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            stack.Push(ex);

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "1":
                        ex += command[1];
                        stack.Push(ex);
                        break;
                    case "2":
                        int count = int.Parse(command[1]);
                        ex = ex.Remove(ex.Length - count);
                        stack.Push(ex);
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        Console.WriteLine(ex[index - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        if (stack.Count!=0)
                        {
                            ex = stack.Peek();
                        }

                       
                        break;
                    default: throw new ArgumentException("invalid command");



                }
            }
        }
    }
}
