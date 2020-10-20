using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {

                string[] names = Console.ReadLine()
           .Split()
           .ToArray();
                foreach (var item in names)
                {
                    elements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
