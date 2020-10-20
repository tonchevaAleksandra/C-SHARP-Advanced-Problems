using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //var list = new List() { 1, 2, 3, 4 };
            //var newList=
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>(input);

            //foreach (var symbol in input)
            //{
            //    reversed.Push(symbol);
            //}

            while (reversed.Any())
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();
        }
    }
}
