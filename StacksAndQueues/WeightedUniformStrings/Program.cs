using System;
using System.Collections.Generic;

namespace WeightedUniformStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            string[] result = weightedUniformStrings(s, queries);

           Console.WriteLine(string.Join("\n", result));

        }
        static string[] weightedUniformStrings(string s, int[] queries)
        {
          
            List<string> result = new List<string>();
            char[] charArray = s.ToCharArray();
            int contigentString = 1;
            int lastAlphaNum = 0;
            List<int> numList = new List<int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                int alphaNum = charArray[i] - 'a' + 1;
                if (alphaNum == lastAlphaNum)
                {
                    contigentString++;
                }
                else
                {
                    contigentString = 1;
                    lastAlphaNum = alphaNum;
                }
                int num = (alphaNum) * contigentString;
                numList.Add(num);
            }
            for (int j = 0; j < queries.Length; j++)
            {
                int x = queries[j];
                if (numList.Contains(x))
                {
                  result.Add("Yes");
                }
                else
                {
                  result.Add("No");
                }
            }

            return result.ToArray();
        }
    }
}
