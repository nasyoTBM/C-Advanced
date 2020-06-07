using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] quantityOrders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quantityOrders);
            Console.WriteLine(orders.Max());
            for (int i = 0; i < quantityOrders.Length; i++)
            {
                if (orders.Peek()<=quantityFood)
                {
                    quantityFood -= orders.Peek();
                    orders.Dequeue();
                   
                }
            }
            if (orders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: {string.Join(" ",orders)}");
            }
            Console.WriteLine();
        }
    }
}
