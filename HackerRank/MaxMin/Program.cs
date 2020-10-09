using System;
using System.Linq;
using System.Numerics;

namespace MaxMin
{
    class Program
    {
        static int maxMin(int k, int[] arr)
        {

            int diff = int.MaxValue;
            arr = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < arr.Length - k + 1; i++)
            {
                int currDiff = (arr[i + k - 1] - arr[i]);
                if (currDiff < diff && currDiff >= 0)
                {
                    diff = currDiff;
                }

            }

            return diff;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            int result = maxMin(k, arr);

            Console.WriteLine(result);
        }
    }
}
