using System;
using System.Linq;

namespace MinimumAbsoluteDifferenceInAnArray
{
    class Program
    {
        static int minimumAbsoluteDifference(int[] arr)
        {

            int minDiff = int.MaxValue;

            arr = arr.OrderByDescending(x => x).ToArray();
            int j = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[j]) < minDiff)
                {
                    minDiff = Math.Abs(arr[i] - arr[j]);
                }
                j++;
            }
            return minDiff;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = minimumAbsoluteDifference(arr);

            Console.WriteLine(result);

        }

    }
}
