using System;
using System.Collections.Generic;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
           var prices = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(p => p * 1.2)
                 .Select(p=>new string($"{p:f2}"))
                 .ToList();

            var stringResults = prices.Select(x => new string($"{x:f2}")).ToArray();
            var result = string.Join(Environment.NewLine, prices);
            Console.WriteLine(result);
        }
    }
}
