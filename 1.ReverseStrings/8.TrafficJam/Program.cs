using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> que = new Queue<string>();
            int counter = 0;
            while (command.ToLower()!="end")
            {
                if (command.ToLower() == "green")
                {
                    if (que.Count < n)
                    {
                        while (que.Count!=0)
                        {
                            Console.WriteLine($"{que.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{que.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    que.Enqueue(command);
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
