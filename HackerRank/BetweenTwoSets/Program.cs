using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int max = a[a.Count-1];
        int start = a.FirstOrDefault(x => x >= max);
        int min = b[0];
        int end = b.FirstOrDefault(x => x <= min);
        List<int> firstDivides = new List<int>();
        for (int i = start; i <= end; i++)
        {
           if(a.TrueForAll(x=>i%x==0))
            {
                firstDivides.Add(i);
            }
        }
        for (int i = 0; i < firstDivides.Count; i++)
        {
          if(!b.TrueForAll(x=>x%firstDivides[i]==0))
            {
                firstDivides.RemoveAt(i);
                i--;
            }
        }
        return firstDivides.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
