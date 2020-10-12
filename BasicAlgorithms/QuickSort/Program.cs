using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            targets = QuickSort(targets, 0, targets.Length - 1);
            Console.WriteLine(string.Join(" ", targets));

        }
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int q = Parition(arr, left, right);
                QuickSort(arr, left, q - 1);
                QuickSort(arr, q + 1, right);
            }
            return arr;
        }
        private static int Parition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int temp;
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }

            arr[right] = arr[i];
            arr[i] = pivot;
            return i;
        }
    }
}
