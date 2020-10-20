using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] clients = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            var orders = new Queue<int>(clients);
            Console.WriteLine(orders.Max());
            while (orders.Any())
            {
                if(quantity<=0)
                {
                    break;
                }
                if(quantity>=orders.Peek())
                {
                   
                    quantity -= orders.Dequeue();
                }
                else
                {

                    break;
                }
            }
            if(orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
