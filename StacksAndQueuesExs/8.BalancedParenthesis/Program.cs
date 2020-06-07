using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _8.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool yes = true;


            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                switch (current)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != current)
                        {
                            yes = false;
                        }
                        break;
                    default:
                        break;
                }

                if (!yes)
                {
                    break;
                }



            }
            Console.WriteLine(yes ? "YES" : "NO");
        }
    }
}