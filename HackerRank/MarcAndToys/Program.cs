using System;
using System.Linq;

namespace MarcAndToys
{
    class Program
    {
        static int maximumToys(int[] prices, int k)
        {
            prices = prices.OrderBy(x => x).ToArray();
            var sum = 0;
            int result = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];
                if(sum>k)
                {
             
                    result = i;
                    break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
            ;
            int result = maximumToys(prices, k);

            Console.WriteLine(result);
        }
    }
}
