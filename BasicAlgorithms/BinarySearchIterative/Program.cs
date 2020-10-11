using System;

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
            var collection = new int[] { 15, 7, 2, 4, 18, 1, 53, 35, 5, 4, 2, 87, 14, 13, 16, 81 };
            Array.Sort(collection);
            int start = 0;
            int end = collection.Length-1;
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine($"Index of searched element if {BinarySearch(collection,key, start, end)}");

        }
    }
}
