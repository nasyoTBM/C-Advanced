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
            int carsToPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            while (input.ToLower()!="end")
            {
                if (input.ToLower()=="green")
                {
                    if (queue.Count>=carsToPass)
                    {
                        for (int i = 0; i < carsToPass; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        while (queue.Count!=0)
                        {

                        
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    
                    
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
