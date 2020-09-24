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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {

        //long sum1 = temp[0] + temp[1] + temp[2] + temp[3];
        //long sum2 = temp[4] + temp[3] + temp[2] + temp[1];
        //Console.WriteLine($"{sum1} {sum2}");
        Array.Sort(arr);
        long min = 0;
         long max = 0;
        for (int i = 0, j = arr.Length - 1; i < arr.Length - 1; i++, j--)
        {
            max  += arr[j];
            min  += arr[i];
        }
        Console.WriteLine(min + " " + max);

    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
