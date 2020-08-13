using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var toss = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);
            //queue.GroupBy(gr => gr.Length)
            //    .Select(queue => queue.Key);
            int currIndex = 1;
            while (queue.Count>1)
            {
                var currentName = queue.Dequeue();
                if(currIndex==toss)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);
                }
                currIndex++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
