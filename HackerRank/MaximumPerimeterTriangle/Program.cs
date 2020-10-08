using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumPerimeterTriangle
{
    class Program
    {
        static long[] maximumPerimeterTriangle(int[] sticks)
        {
            List<long> result = new List<long>();
            Array.Sort(sticks);
            var maxPerimeter = int.MinValue;
         
            for (int i= sticks.Length-1; i >=2; i--)
            {
                var maxSide = sticks[i];
                var currPerimeter = sticks[i - 1] + sticks[i - 2] + maxSide;
                if(sticks[i-1]+sticks[i-2]> maxSide 
                    && currPerimeter > maxPerimeter)
                {
                    maxPerimeter = currPerimeter;
                  result.Add(sticks[i - 2]);
                  result.Add(sticks[i - 1]);
                   result.Add( maxSide);
                   
                }
   
            }
            if(!result.Any())
            {
                return new long[] { -1 };
            }
            return result.OrderBy(x => x).ToArray();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp))
            ;
            long[] result = maximumPerimeterTriangle(sticks);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
