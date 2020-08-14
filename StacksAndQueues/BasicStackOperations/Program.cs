using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
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
            Stack<int> numbers = new Stack<int>(nums);
            for (int i = 0; i < s; i++)
            {
                if (numbers.Any())
                {
                    numbers.Pop();
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
                    int smallest = numbers.Min();
                    Console.WriteLine(smallest);
                }
                else
                {
                    Console.WriteLine(0);
                } 
            }
        }
    }
}
