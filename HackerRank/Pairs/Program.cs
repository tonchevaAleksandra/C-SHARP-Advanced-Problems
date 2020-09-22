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

    // Complete the pairs function below.
    static int pairs(int k, int[] arr)
    {
        var i = 0;
        var j = 1;
        var count = 0;
        arr = arr.OrderBy(x => x).ToArray();
        while (j < arr.Length)
        {
            var diff = arr[j] - arr[i];

            if (diff == k)
            {
                count++;
                j++;
            }
            else if (diff > k)
            {
                i++;
            }
            else if (diff < k)
            {
                j++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = pairs(k, arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
