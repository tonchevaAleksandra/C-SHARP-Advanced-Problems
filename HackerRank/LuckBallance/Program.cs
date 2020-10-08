using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBallance
{
    class Program
    {
        static int luckBalance(int k, int[][] contests)
        {
            var importantExams = new List<int>();
            var unimportantExams = new List<int>();

            for (int i = 0; i < contests.GetLength(0); i++)
            {
                if(contests[i][1]==1)
                {
                    importantExams.Add(contests[i][0]);
                }
                else
                {
                    unimportantExams.Add(contests[i][0]);
                }
            }
            importantExams.Sort();
            int luck = 0;
            luck+= unimportantExams.Sum();
            if (importantExams.Count>k)
            {
                luck -= importantExams.Take(importantExams.Count - k).Sum();
                luck += importantExams.Skip(importantExams.Count - k).Sum();

            }
            else
            {
                luck += importantExams.Sum();
            }
            return luck;
        }
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[][] contests = new int[n][];

            for (int i = 0; i < n; i++)
            {
                contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
            }

            int result = luckBalance(k, contests);

            Console.WriteLine(result);

        }
    }
}
