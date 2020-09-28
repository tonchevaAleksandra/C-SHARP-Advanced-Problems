using System;

using System.Collections.Generic;

namespace ImplementingQueue
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue<int>();
            for (int i = 0; i < 6; i++)
            {
                queue.Enqueue(i+1);
            }

            string[] collection = new string[10];
            for (int i = 0; i < 10; i++)
            {
                collection[i] = $"some {i}";
            }

            var firstQueue = new MyQueue<string>(collection);
            Console.WriteLine(firstQueue.Peek());
            //firstQueue.Foreach(Console.WriteLine);
        
        }
    }
}
