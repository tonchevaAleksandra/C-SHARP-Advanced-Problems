using System;
using System.Linq;

namespace BinarySearchIterative
{
    class Program
    {
       static int BinarySearch(int[] arr, int key, int start, int end)
        {
            while (end>=start)
            {
                int mid = (start + end) / 2;
                if(arr[mid]<key)
                {
                    start = mid + 1;
                }
                else if(arr[mid]>key)
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {

            int[] collection = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            Array.Sort(collection);
            int start = 0;
            int end = collection.Length-1;
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine($"{BinarySearch(collection,key, start, end)}");

        }
    }
}
