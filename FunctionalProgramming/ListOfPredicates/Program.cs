using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {

            var end = int.Parse(Console.ReadLine());

            var arr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Distinct()
                 .ToList();


            List<int> result = new List<int>();
            result = GetDivisibleNumbers(end, arr);

            Console.WriteLine(string.Join(" ", result));


            //int n = int.Parse(Console.ReadLine());

            //List<int> dividers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .Distinct()
            //    .ToList();
            //List<int> result = new List<int>();


            //for (int i = 1; i <= n; i++)
            //{
            //    Predicate<int> predicates = x => x % 1 == 0;

            //    foreach (var divider in dividers)
            //    {
            //        predicates += x => x % divider == 0;
            //    }

            //    if (predicates(i))
            //    {
            //        result.Add(i);
            //    }     
            //}



            //Console.WriteLine(string.Join(" ", result));

        }

        private static List<int> GetDivisibleNumbers(int n, List<int> divisors)
        {
            var divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                var isDivisible = true;

                foreach (var d in divisors)
                {
                    Predicate<int> isNotDivisor = x => num % x != 0;

                    if (isNotDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            return divisibleNumbers;
        }
    }
}
