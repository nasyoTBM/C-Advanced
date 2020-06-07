using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> carsQue = new Queue<string>();
            int counter = 0;
            while (command != "END")
            {
                if (command == "green" && carsQue.Count!=0)
                {
                    
                        string currentCar = carsQue.Peek();
                        Queue<char> singleCar = new Queue<char>(carsQue.Peek());

                        for (int i = 0; i < greenLightDuration; i++)
                        {

                            singleCar.Dequeue();

                            if (singleCar.Count == 0)
                            {
                                counter++;
                                carsQue.Dequeue();

                                if (carsQue.Count != 0)
                                {
                                    
                                    currentCar = carsQue.Peek();
                                    singleCar = new Queue<char>(carsQue.Peek());

                                }
                                else
                                {
                                    break;
                                }

                            }

                        }
                        
                         if (freeWindowDuration-singleCar.Count<0)
                        {
                            for (int i = 0; i < freeWindowDuration; i++)
                            {
                                singleCar.Dequeue();

                            }
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {singleCar.Dequeue()}.");
                            return;
                        }
                        else if (singleCar.Count!=0)
                        {
                        carsQue.Dequeue();
                        counter++;
                            
                        }
                    
                    
                    

                }
                else if(command!="green")
                {
                    carsQue.Enqueue(command);
                }




                command = Console.ReadLine();

            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }

    }
}