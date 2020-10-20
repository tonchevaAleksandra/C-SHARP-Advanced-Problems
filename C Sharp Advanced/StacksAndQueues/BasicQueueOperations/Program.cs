using System;
using System.Linq;
using System.Collections.Generic;
namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int n = targets[0];
            int s = targets[1];
            int x = targets[2];

            int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Queue<int> numbers = new Queue<int>(nums);
            for (int i = 0; i < s; i++)
            {
                if(numbers.Any())
                {
                    numbers.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if(numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
