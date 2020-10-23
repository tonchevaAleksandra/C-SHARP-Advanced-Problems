using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int m = Convert.ToInt32(Console.ReadLine());

            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
            ;
            int[] result = missingNumbers(arr, brr);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] missingNumbers(int[] arr, int[] brr)
        {
            List<int> result = new List<int>();
            List<int> first = new List<int>(arr);
            List<int> second = new List<int>(brr);
           
            foreach (var item in second)
            {
                if (first.Contains(item))
                {
                    first.Remove(item);
                }
                else
                {
                    if(!result.Contains(item))
                    {
                        result.Add(item);
                    }
                    
                }
            }
         
            return result.OrderBy(x => x).ToArray();
        }
    }
}
