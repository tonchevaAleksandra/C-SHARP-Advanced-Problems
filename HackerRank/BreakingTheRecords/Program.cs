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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int min = scores[0];
        int max = scores[0];
        int countIncreased = 0;
        int countDecreased = 0;
        for (int i = 1; i < scores.Length; i++)
        {
            if(scores[i]>max)
            {
                max = scores[i];
                countIncreased++;
            }
            if(scores[i]<min)
            {
                min = scores[i];
                countDecreased++;
            }
        }
        int[] result = new int[2];
        result[0] = countIncreased;
        result[1] = countDecreased;
        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        Console.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
