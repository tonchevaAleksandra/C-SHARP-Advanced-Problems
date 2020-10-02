using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                list.Add(a);
            }


            int[] targets = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            var box = new Box<string>(list);
            box.Swap(targets[0], targets[1]);
            Console.WriteLine(box.ToString());
         
        }
    }
}
