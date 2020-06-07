using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> racks = new Stack<int>(clothes);
            int sum = 0;
            int counter = 1;
            while (racks.Count>0)
            {

                sum += racks.Peek();

                if (sum <= rackCapacity)
                {
                    racks.Pop();
                }

                else

                {
                   
                    sum = 0;
                    counter++;
                }
            }
            
            Console.WriteLine(counter);
            
        }
    }
}
