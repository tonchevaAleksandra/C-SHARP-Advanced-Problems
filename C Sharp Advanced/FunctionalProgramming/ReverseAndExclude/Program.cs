using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Reverse()
                 .ToList();

            int toDivide = int.Parse(Console.ReadLine());

            Func<int, bool> predicate = n => n%toDivide !=0;

            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));

            numbers = numbers.Where(predicate)
                  .ToList();
            print(numbers);

        }
    }
}
