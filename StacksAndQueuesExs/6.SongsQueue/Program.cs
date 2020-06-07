using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            Queue<string> songQ = new Queue<string>(songs);
            
            while (songQ.Count>0)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Play":songQ.Dequeue();
                        break;
                    case "Add":
                                string song = "";
                                for (int i = 1; i < command.Length; i++)
                                {
                                    if (i!=command.Length-1)
                                    {
                                        song += command[i] + " ";
                                    }
                                    else
                                    {
                                        song += command[i];
                                    }
                            
                                }
                                if (songQ.Contains(song))
                                {
                                    Console.WriteLine($"{song} is already contained!");
                                }
                                else
                                {
                                    songQ.Enqueue(song);
                                }
                       
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songQ));
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                        
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
