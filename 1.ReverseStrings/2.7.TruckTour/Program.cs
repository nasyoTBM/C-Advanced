using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<int[]> que = new Queue<int[]>(pumpsCount);
            bool completed = true;
            int tank = 0;
            int index = 0;

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] pump = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                que.Enqueue(pump);
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                for (int j = 0; j < pumpsCount; j++)
                {
                    int petrolAmount = que.Peek()[0];
                    int distanceToNext = que.Peek()[1];
                    tank += petrolAmount;

                    if (tank >= distanceToNext)
                    {
                        tank -= distanceToNext;

                    }
                    else
                    {

                        completed = false;

                    }
                    que.Enqueue(que.Dequeue());

                }

                que.Enqueue(que.Dequeue());

                if (completed)
                {
                    index = i;
                    break;

                }

            }

            Console.WriteLine(index);
        }
    }
}


            