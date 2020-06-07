using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bulletStack = new Stack<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> locksQue = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletCounter = 0;
            int bulletsPrice = 0;
            
           
            while ( (locksQue.Count!=0) && (bulletStack.Count!=0))
            {
                int counter = 0;
                for (int i = 0; i < gunBarrelSize; i++)
                {
                    counter++;
                    if (bulletStack.Count==0 || locksQue.Count == 0)
                    {
                        break;
                    }
                    int bullet = bulletStack.Pop();
                    int singleLock = locksQue.Peek();
                    bulletCounter++;
                    if (bullet<=singleLock)
                    {
                        Console.WriteLine("Bang!");
                        locksQue.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }
                if (bulletStack.Count > 0 && counter == gunBarrelSize)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            bulletsPrice = bulletCounter * bulletPrice;
            if (bulletStack.Count==0 && locksQue.Count!=0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQue.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${intelligenceValue-bulletsPrice}");
            }
        }
    }
}
