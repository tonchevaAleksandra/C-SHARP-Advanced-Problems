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
        int level = 0;
        var arr = path.ToCharArray();
        foreach (var item in arr)
        {
            if (item == 'D') level--;
            else level++;
            if (level == 0 && item == 'U') count++;
            
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
