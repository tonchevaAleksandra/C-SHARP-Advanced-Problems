using System;
using System.Collections.Generic;
using System.Linq;

namespace SumNumbers
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myFunc = int.Parse;

            var numbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(myFunc)
                .ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
 