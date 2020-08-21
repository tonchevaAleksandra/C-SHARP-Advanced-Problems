using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> counts = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }
                counts[num]++;
            }

            counts = counts.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in counts)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
