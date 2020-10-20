using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var borders = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            string filter = Console.ReadLine();

            //int a = 5;
            //int b = a > 3 ? a : 10;// true => b=a => b=5

            Predicate<int> predicate = filter == "odd" ?
                new Predicate<int>(n => n % 2 != 0) : new 
                Predicate<int>(n => n % 2 == 0);

            List<int> result = new List<int>();

            for (int i = borders[0]; i <= borders[1]; i++)
            {
                if(predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

