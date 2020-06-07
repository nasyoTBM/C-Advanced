using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);
            Console.WriteLine(orders.Max());
            for (int i = 0; i < input.Length; i++)
            {
                if (quantityOfFood-input[i]>=0)
                {
                    orders.Dequeue();
                    quantityOfFood -= input[i];
                }
                else
                {
                    break;
                }
            }
            if (orders.Count!=0)
            {
                Console.Write($"Orders left: {(string.Join(" ", orders))}");
                
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
