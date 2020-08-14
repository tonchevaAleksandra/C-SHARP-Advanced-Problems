using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] clothes = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            int racks = 1;

            var stack = new Stack<int>(clothes);

            int capacity = int.Parse(Console.ReadLine());

            int sum = 0;
            while (stack.Any())
            {
                if(capacity<sum+stack.Peek())
                {
                    racks++;
                    sum = 0;
                }
                sum+=stack.Pop();
                              
            }
         
            Console.WriteLine(racks);
        }
    }
}
