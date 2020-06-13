using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input.ToLower()!="revision")
            {
                string[] productInfo = input
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .ToArray();
                string storeName = productInfo[0];
                string product = productInfo[1];
                double price = double.Parse(productInfo[2]);
                if (!dict.ContainsKey(storeName))
                {
                    dict.Add(storeName, new Dictionary<string, double>());
                    dict[storeName].Add(product, price);
                }
                else
                {
                    dict[storeName].Add(product, price);
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:F1}");
                }
            }

        }
    }
}
