using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            Stack<int> males = new Stack<int>(targets);

            int[] targets1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Queue<int> females = new Queue<int>(targets1);

            int matchesCount = 0;

            while (males.Any() && females.Any())
            {
                var male = males.Peek();
                var female = females.Peek();

                if (male <= 0)
                {
                    males.Pop();
                    continue;

                }
                if (female <= 0)
                {
                    females.Dequeue();

                    continue;
                }
                if (males.Peek() % 25 == 0 && males.Peek() != 0)
                {
                    males.Pop();
                    if (males.Any())
                    {
                        males.Pop();
                    }

                    continue;

                }
                if (females.Peek() % 25 == 0 && females.Peek() != 0)
                {
                    females.Dequeue();
                    if (females.Any())
                    {
                        females.Dequeue();
                    }
                    continue;

                }
                if (males.Peek() == females.Peek())
                {
                    males.Pop();
                    females.Dequeue();
                    matchesCount++;
                    continue;
                }
                else if (male != female)
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(male - 2);
                    continue;
                }


            }

            PrintResult(males, females, matchesCount);
        }

        private static void PrintResult(Stack<int> males, Queue<int> females, int matchesCount)
        {
            Console.WriteLine($"Matches: {matchesCount}");
            if (!males.Any())
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            if (!females.Any())
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
