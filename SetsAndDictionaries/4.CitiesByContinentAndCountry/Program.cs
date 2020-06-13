using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < entries; i++)
            {
                string[] entry = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string continent = entry[0];
                string country = entry[1];
                string city = entry[2];
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new List<string>());
                        dict[continent][country].Add(city);
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new List<string>());
                        dict[continent][country].Add(city);
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }
                }

            }
            foreach (var continent in dict)
            {
                Console.WriteLine(continent.Key+":");
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> {string.Join(", ",country.Value)}");
                    Console.WriteLine();
                }
                
            }

        }
    }
}
