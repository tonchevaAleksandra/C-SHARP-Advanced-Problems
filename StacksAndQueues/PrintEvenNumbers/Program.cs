using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(arr.Where(x=>x%2==0));
            Console.WriteLine(string.Join(", ",numbers));
            
        }
    }
}
