using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
            while (input.ToLower()!="end")
            {
                string[] carPlate = input
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .ToArray();
                string command = carPlate[0];
                string number = carPlate[1];

               if(command == "IN")
                {
                    parking.Add(number);
                }
               else if(command == "OUT")
                {
                    parking.Remove(number);
                }
                input = Console.ReadLine();
                      
            }
            if (parking.Count!=0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
