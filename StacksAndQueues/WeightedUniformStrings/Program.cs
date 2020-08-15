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
            string[] result = new string[queries.Length];
            List<int> stringToNums = new List<int>();
            foreach (var item in s)
            {
                stringToNums.Add(item - 96);
            }
            List<int> sumsOfSeq = new List<int>();
            bool isMatched = false;
            for (int k = 0; k < stringToNums.Count-1; k++)
            {

                int currSum = stringToNums[k];
                for (int l = k+1; l < stringToNums.Count; l++)
                {

                    if(stringToNums[k]==stringToNums[l])
                    {
                        currSum += stringToNums[l];
                        k++;
                        isMatched = true;

                    }
                    else
                    {
                        isMatched = false;
                        break;
                    }
                }
               
                sumsOfSeq.Add(currSum);
               
            }
            if(!isMatched)
            {
                sumsOfSeq.Add(stringToNums[stringToNums.Count - 1]);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                if(sumsOfSeq.Contains(queries[i]) || stringToNums.Contains(queries[i]))
                {
                    result[i] = "Yes";
                }
                else
                {
                    result[i] = "No";
                }
            }
           
            
            return result;
        }
    }
}
