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
            Stack<string> input = new Stack<string>(Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
            Stack<string> reversed = new Stack<string>();
            int length = input.Count;
            
            while (input.Count!=0)
            {
                reversed.Push(input.Pop());
            }
            while (reversed.Count>1)
            {
                int firstNum = int.Parse(reversed.Pop());
                string command = reversed.Pop();
                int secondNum = int.Parse(reversed.Pop());
                int result = 0;
                if (command == "+")
                {
                    result = firstNum + secondNum;
                    reversed.Push(result.ToString());
                   
                }
                if (command=="-")
                {
                    result = firstNum - secondNum;
                    reversed.Push(result.ToString());
                }
            }
            Console.WriteLine(reversed.Peek());
        }
    }
}
