using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        for (int i = 0; i < s.Count-m+1; i++)
        {
            int[] arr=s.GetRange(i, m).ToArray();
            if(arr.Sum()==d)
            {
                count++;
            }
        }
        return count;
        //s = s.OrderBy(x => x)
        //        .Where(x => x < d).ToList();
        
        
        

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
