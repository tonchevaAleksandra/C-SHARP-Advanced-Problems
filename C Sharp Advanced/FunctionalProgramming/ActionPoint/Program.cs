using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {

            //Action<string> print = x => Console.WriteLine(x);

          Console.ReadLine()
                 .Split()
                 .ToList()
                 .ForEach(new Action<string>(name=>Console.WriteLine(name)));

        }
    }
}
