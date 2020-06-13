using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] {",", " -> " }, StringSplitOptions.None)
                    .ToArray();
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(input[j]))
                        {
                            wardrobe[color].Add(input[j], 1);
                        }
                        else
                        {
                            wardrobe[color][input[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(input[j]))
                        {
                            wardrobe[color].Add(input[j], 1);
                        }
                        else
                        {
                            wardrobe[color][input[j]]++;
                        }
                    }
                }
            }
            string[] lookFor = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key==lookFor[0] && item.Key==lookFor[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                   
                }
            }
        }
        
    }
}
