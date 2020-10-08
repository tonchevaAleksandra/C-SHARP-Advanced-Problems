using System;
using System.Collections.Generic;
using System.Linq;

namespace Candies
{
    class Program
    {
        static long candies(int n, int[] arr)
        {
            
            var list = new List<long>();
            list.Add(1);
            for (int i = 1; i < n; i++)
            {
              
                list.Add(1);
                if (arr[i]>arr[i-1])
                {
                    list[i]=list[i - 1] + 1;
                }
            }
            for (int i = n-1; i > 0; i--)
            {
                if (arr[i]<arr[i-1])
                {
                    list[i - 1] = Math.Max(list[i - 1], list[i] + 1);
                }
            }

            return list.Sum();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            long result = candies(n, arr);

            Console.WriteLine(result);
        }
    }
}
