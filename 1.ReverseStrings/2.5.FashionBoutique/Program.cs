using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int counter = 1;
            int total = 0;
            while (clothes.Count!=0)
            {
                
                
                    if (total + clothes.Peek() <= rackCapacity)
                    {
                        total += clothes.Pop();
                    }
                    else
                    {
                        counter++;
                        total = 0;
                    }
                
                
            }
            Console.WriteLine(counter);

        }
    }
}
