using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count != 0)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "play")
                {
                    songs.Dequeue();
                }
                else if (command.Substring(0, 3).ToLower() == "add")
                {
                    if (!songs.Contains(command.Substring(4)))
                    {
                        songs.Enqueue(command.Substring(4));
                    }
                    else
                    {
                        Console.WriteLine($"{command.Substring(4)} is already contained!");
                    }
                    
                }
                else if (command.ToLower() == "show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
