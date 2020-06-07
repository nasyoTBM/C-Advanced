using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> que = new Queue<string>();
            while (input!= "End")
            {
                if (input=="Paid" && que.Count!=0)
                {
                    while (que.Count!=0)
                    {

                        Console.WriteLine(que.Dequeue());
                    }
                }
                else
                {
                    que.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{que.Count} people remaining.");
        }
    }
}
