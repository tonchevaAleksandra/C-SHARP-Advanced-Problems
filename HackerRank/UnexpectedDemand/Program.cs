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
     * Complete the 'findSubstring' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string findSubstring(string s, int k)
    {
        string result = string.Empty;
        int maxCount = 0;


        int i = 0;
        if (!s.Contains('a') && !s.Contains('o') && !s.Contains('e') && !s.Contains('i') && !s.Contains('u'))
        {
            return "Not found!";
        }
        else
        {
            while (i + k <= s.Length)
            {

                string curr = s.Substring(i, k);
                //List<char> arr = new List<char>();
                //arr = curr.ToArray().Where(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u').ToList();
                int j = 0;
                int count = 0;
                while (j < curr.Length)
                {
                    char c = curr[j];
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        count++;
                    }

                    j++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    result = curr;
                }

                i++;
            }
            return result;
        }



    }
}




class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.findSubstring(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
