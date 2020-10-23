using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            var stack = new Stack<int>(numbers);
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command.ToLower())
                {
                    case "add":
                        int first = int.Parse(cmdArgs[1]);
                        int second = int.Parse(cmdArgs[2]);
                        stack.Push(first);
                        stack.Push(second);
                        break;
                    case "remove":
                        int count = int.Parse(cmdArgs[1]);
                        if (count <= stack.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
