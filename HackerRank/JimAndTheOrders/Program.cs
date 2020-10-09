using System;
using System.Collections.Generic;
using System.Linq;

namespace JimAndTheOrders
{
    class Program
    {
        static int[] jimOrders(int[][] orders)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < orders.GetLength(0); i++)
            {
                var currTime = orders[i][0] + orders[i][1];
                dict.Add(i + 1, currTime);
            }
            return dict.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToArray();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] orders = new int[n][];

            for (int i = 0; i < n; i++)
            {
                orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            }

            int[] result = jimOrders(orders);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
