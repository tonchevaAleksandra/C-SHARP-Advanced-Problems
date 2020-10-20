using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int totalCars = 0;
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                if(input=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(queue.Any())
                        {
                           string currCar= queue.Dequeue();
                            Console.WriteLine($"{currCar} passed!");
                            totalCars++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{totalCars} cars passed the crossroads.");
        }
    }
}
