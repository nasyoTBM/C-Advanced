using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < entries; i++)
            {
                string[] entry = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string student = entry[0];
                decimal grade = decimal.Parse(entry[1]);
                if (!dict.ContainsKey(student))
                {
                    dict.Add(student, new List<decimal>());
                    dict[student].Add(grade);
                }
                else
                {
                    dict[student].Add(grade);
                }
            }
            foreach (var item in dict)
            {
                double avg = 0;
                Console.Write($"{item.Key} ->");
                foreach (var student in item.Value)
                {
                    Console.Write($" {student:F2}");
                    
                }
                Console.Write($" (avg: {item.Value.Average():F2})");
                Console.WriteLine();
            }
        }
    }
}
