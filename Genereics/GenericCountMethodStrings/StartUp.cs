using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
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

            var element = Console.ReadLine();
            var box = new Box<string>(list);
            Console.WriteLine(box.CountGreaterElements(list, element));

        }
    }
}
