using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool completed = true;
            for (int i = 0; i < parentheses.Length; i++)
            {
                if (parentheses[i] == '{' || parentheses[i] == '[' || parentheses[i] == '(')
                {
                    stack.Push(parentheses[i]);
                }
                else if (parentheses[i] == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{' )
                    {
                        completed = false;
                    }
                }
                else if (parentheses[i] == ']')
                {
                    if (stack.Count == 0 ||stack.Pop() != '['  )
                    {
                        completed = false;
                    }
                }
                else if (parentheses[i] == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(' )
                    {
                        completed = false;
                    }
                }
                if (!completed)
                {
                    break;
                }
            }
            Console.WriteLine(completed ? "YES" : "NO");
        }
    }
}

