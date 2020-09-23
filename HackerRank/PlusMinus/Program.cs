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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        //        0.400000
        //0.400000
        //0.200000
        int posCount = 0;
        int negCount = 0;
        int zeroCount = 0;
        foreach (var item in arr)
        {
            if (item < 0) negCount++;
            if (item == 0) zeroCount++;
            if (item > 0) posCount++;
        }

        decimal first = posCount * 1.00M / arr.Length;
        decimal sec  = negCount * 1.00M / arr.Length;
        decimal third = zeroCount * 1.00M / arr.Length;
        Console.WriteLine($"{first:f6}");
        Console.WriteLine($"{sec:f6}");
        Console.WriteLine($"{third:f6}");

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
