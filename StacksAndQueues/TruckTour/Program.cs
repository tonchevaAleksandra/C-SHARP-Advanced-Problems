using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(global::System.Console.ReadLine());
            Queue<int[]> stations = new Queue<int[]>();
            int counter = 0;
            FillTheQueue(n, stations);

            while (true)
            {
                int fuelAmount = 0;
               
                bool isFound = true;

                for (int st = 0; st < n; st++)
                {
                    int[] currstation = stations.Dequeue();
                    fuelAmount += currstation[0];

                    if(fuelAmount<currstation[1])
                    {
                        isFound = false;
                    }

                    fuelAmount -= currstation[1];

                    stations.Enqueue(currstation);
                }

                if(isFound)
                {
                    break;
                }

                counter++;

                stations.Enqueue(stations.Dequeue());
            }

            Console.WriteLine(counter);

        }

        private static void FillTheQueue(int n, Queue<int[]> stations)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                stations.Enqueue(input);

            }
        }
    }
   
}
