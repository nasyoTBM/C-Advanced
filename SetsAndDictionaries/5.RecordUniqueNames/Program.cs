using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < entries; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
