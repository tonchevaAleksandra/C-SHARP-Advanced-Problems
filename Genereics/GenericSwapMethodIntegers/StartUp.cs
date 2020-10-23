using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }


            int[] targets = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            var box = new Box<int>(list);
            box.Swap(targets[0], targets[1]);
            Console.WriteLine(box.ToString());
        }
    }
}
