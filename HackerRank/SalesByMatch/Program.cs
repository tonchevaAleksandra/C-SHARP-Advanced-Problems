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

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var count = 0;
        Dictionary<int, int> countNums = new Dictionary<int, int>();
        foreach (var item in ar)
        {
            if (!countNums.ContainsKey(item))
            {
                countNums.Add(item, 1);
            }
            else
            {
                if(countNums[item]%2!=0)
                {
                    count++;
                    countNums[item] = 0;
                }
                else
                {
                    countNums[item]++;
                }
            }

        }

       
        return count ;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
