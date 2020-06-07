using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            }


            for (int i = 0; i < n; i++)
            {
                int totalFuel = 0;
                bool isCircle = true;

                for (int j = 0; j < n; j++)
                {
                    int currentFuel = pumps.Peek()[0];
                    int distance = pumps.Peek()[1];
                    totalFuel += currentFuel;

                    if (totalFuel >= distance)
                    {
                        totalFuel -= distance;

                    }
                    else
                    {
                        isCircle = false;

                    }

                    pumps.Enqueue(pumps.Dequeue());
                }

                if (isCircle)
                {
                    index = i;
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(index);
        }
    }
}
