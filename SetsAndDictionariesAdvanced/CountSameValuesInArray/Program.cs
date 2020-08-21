using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
             .Split()
             .Select(double.Parse)
             .ToArray();

            Dictionary<double, int> countNums = new Dictionary<double, int>();
            foreach (var item in numbers)
            {
                if(!countNums.ContainsKey(item))
                {
                    countNums.Add(item, 0);
                }
                countNums[item]++;
               
            }

            foreach (var (key,value) in countNums)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
