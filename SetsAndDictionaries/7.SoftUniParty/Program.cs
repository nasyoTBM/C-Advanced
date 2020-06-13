using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> vipList = new HashSet<string>();
            HashSet<string> list = new HashSet<string>();

            while (input!="END")
            {
                if (input == "PARTY")
                {
                    while (input!="END")
                    {
                        if (IsVip(input))
                        {
                            vipList.Remove(input);
                        }
                        else
                        {
                            list.Remove(input);
                        }
                        
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    if (IsVip(input))
                    {
                        vipList.Add(input);
                    }
                    else
                    {
                        list.Add(input);
                    }
                    
                    input = Console.ReadLine();
                }
                
            }
            
            Console.WriteLine(list.Count+vipList.Count);
            foreach (var item in vipList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static bool IsVip(string word)
        {
            if (char.IsDigit(word[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
