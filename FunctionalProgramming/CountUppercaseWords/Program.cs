using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine()
            //     .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            //     .Where(word => char.IsUpper(word[0]))
            //     .ToList()
            //     .ForEach(Console.WriteLine);

            Func<string, bool> func = word => char.IsUpper(word[0]);

            Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(func)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
