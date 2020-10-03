using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                list.Add(a);
            }

            var element = double.Parse(Console.ReadLine());
            var box = new Box<double>(list);
            Console.WriteLine(box.CountGreaterElements(list, element));
        }
    }
}
