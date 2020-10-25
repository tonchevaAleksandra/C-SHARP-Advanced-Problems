using System;
using System.Collections.Generic;
using System.Linq;

namespace Sheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Stack<int> tasks = new Stack<int>(targets);

            int[] targets1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Queue<int> threads = new Queue<int>(targets1);

            int taskToBeKill = int.Parse(Console.ReadLine());


            while (threads.Any() && tasks.Any())
            {
                if (tasks.Peek() == taskToBeKill)
                {
                    Console.WriteLine($"Thread with value { threads.Peek()} killed task { taskToBeKill}");
                    break;
                }
                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (threads.Peek() < tasks.Peek())
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
