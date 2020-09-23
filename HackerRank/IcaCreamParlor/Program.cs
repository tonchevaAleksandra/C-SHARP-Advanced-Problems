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

    // Complete the icecreamParlor function below.
    static int[] icecreamParlor(int m, int[] arr)
    {
        var result = new int[2];
        var prices = new Dictionary<int, int>();
        for (var i = 1; i <= arr.Length; i++)
        {
            var diff = m - arr[i - 1];
            if (prices.ContainsKey(diff))
            {
                result[0] = prices[diff];
                result[1] = i;
                
                break;
            }
            else
            {
                prices.Add(arr[i - 1], i);
            }
        }
        Array.Sort(result);
        return result;
       
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = icecreamParlor(m, arr);

            Console.WriteLine(string.Join(" ", result));
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
