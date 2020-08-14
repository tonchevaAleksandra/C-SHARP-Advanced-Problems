using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "1":
                        numbers.Push(int.Parse(cmdArgs[1]));
                        break;
                    case "2":
                        if(numbers.Any())
                        {
                            numbers.Pop();
                        }
                        break;
                    case "3":
                        if(numbers.Any())
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if(numbers.Any())
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

