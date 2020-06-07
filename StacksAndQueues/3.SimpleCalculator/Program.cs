using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operator_ = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
           
                switch (operator_)
                {
                    case "+": stack.Push((firstNum + secondNum).ToString());
                        
                        break;
                    case "-": stack.Push((firstNum - secondNum).ToString());
                        break;
                    default:
                        throw new ArgumentException("Invalid operator");
                        
                }

            }
            Console.WriteLine(stack.Peek());

        }
    }
}
