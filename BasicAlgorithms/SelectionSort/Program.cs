using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] collection = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();
          
            for (int i = 0; i < collection.Length; i++)
            {
                int min = i;
                
                for (int j = i+1; j < collection.Length; j++)
                {
                    if (Less(collection[j],collection[min]))
                    {
                        min = j;
                    }
                }
                Swap(collection, i, min);
                Print(collection);
            }
            Print(collection);
        }

        private static void Print(int[] collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }

        private static int[] Swap(int[] collection, int i, int min)
        {
            var temp = collection[i] ;
            collection[i] = collection[min];
            collection[min] = temp;
            return collection;
        }

        private static bool Less(int first, int second)
        {
            return first < second ? true : false;
        }
    }
}
