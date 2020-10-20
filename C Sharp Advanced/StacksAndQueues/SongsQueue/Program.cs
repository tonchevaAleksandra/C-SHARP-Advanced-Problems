using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] songs = Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            var queue = new Queue<string>(songs);
           
            while (queue.Any())
            {
                string[] cmdArgs = Console.ReadLine().Split();
               
                switch (cmdArgs[0])
                {
                   
                    case "Play":
                        queue.Dequeue();
                        if(!queue.Any())
                        {
                            Console.WriteLine("No more songs!");
                            return;
                        }
                        break;
                    case "Add":
                        var arr = new List<string>(cmdArgs);
                        arr.RemoveAt(0);
                        string song = string.Join(" ",arr);
                        

                        if(!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",queue));
                        break;
                    default:
                        break;
                }
            }           
        }
    }
}
