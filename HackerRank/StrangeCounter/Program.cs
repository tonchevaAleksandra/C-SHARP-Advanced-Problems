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

    // Complete the strangeCounter function below.
    static long strangeCounter(long t)
    {
        long cycle = 3;
        while (t>cycle)
        {
            t -= cycle;
            cycle *= 2;
        }

        return (cycle - t + 1);
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine());

        long result = strangeCounter(t);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
