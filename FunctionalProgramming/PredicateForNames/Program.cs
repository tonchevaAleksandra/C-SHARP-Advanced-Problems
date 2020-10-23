using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            Func<string, bool> filter = n => n.Length <= nameLength;

            Console.ReadLine()
                  .Split()
                  .Where(filter)
                  .ToList()
                  .ForEach(Console.WriteLine);

        }
    }
}
