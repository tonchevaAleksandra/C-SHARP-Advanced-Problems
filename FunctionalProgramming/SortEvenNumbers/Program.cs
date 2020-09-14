using System;
using System.Collections.Generic;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> nums= Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList()
                //.ForEach(Console.WriteLine) - it's low performence => fast perf. is a normal foreach and fastes perf. is for 
               ;

            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
