using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                if(input!="Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine,names));
                    names.Clear();
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
