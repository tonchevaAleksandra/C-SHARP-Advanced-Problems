using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new int[] { 15, 7, 2, 4, 18, 1, 53, 35, 5, 4, 2, 87, 14, 13, 16, 81 };
            Print(collection);
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
