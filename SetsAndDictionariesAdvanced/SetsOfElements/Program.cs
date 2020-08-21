using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lengths = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            int n = lengths[0];
            int m = lengths[1];
            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(" ",a.Intersect(b)));
        }
    }
}
