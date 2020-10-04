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

    public static int countingValleys(int steps, string path)
    {
        int count = 0;
        string pattern = @"([D]+[U]+[D]+)";
        MatchCollection matches = Regex.Matches(path, pattern);
        string patternD = @"[D]+";
        string patternU = @"[U]+[D]+";
        foreach (Match match in matches)
        {
            string[] matchArgs = match.Value.Split(@"[U]+");
            count += Math.Min(matchArgs[0].Length, matchArgs[1].Length);

        }
       
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);


    }
}
