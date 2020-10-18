using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(input);
            List<int> people = new List<int>();
            Queue<char> halls = new Queue<char>();

            int sum = 0;
            while (stack.Any())
            {
                var currElement = stack.Pop();
                if (char.IsLetter(currElement[0]))
                {
                    halls.Enqueue(char.Parse(currElement));

                }
                else
                {
                    if(!halls.Any())
                    {
                        continue;
                    }
                    if (sum+ int.Parse(currElement) > hallsMaxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", people)}");

                        people.Clear();
                        sum = 0;
                    }
                    if (halls.Any())
                    {
                        people.Add(int.Parse(currElement));
                        sum += (int.Parse(currElement));
                    }

                }

            }

        }
    }
}
