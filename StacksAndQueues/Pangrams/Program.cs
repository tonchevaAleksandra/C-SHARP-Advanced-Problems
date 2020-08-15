
using System.Collections.Generic;

using System.IO;
using System.Linq;

using System;

class Solution
{

    // Complete the pangrams function below.
    static string pangrams(string s)
    {
        string result = string.Empty;
        Queue<char> queue = new Queue<char>();
        for (char x = 'a'; x <= 'z'; x++)
        {
            queue.Enqueue(x);
        }
        bool isFailed = false;
        while (queue.Any())
        {
            if (s.Contains(queue.Peek()))
            {
                queue.Dequeue();
            }
            else
            {
                isFailed = true;
                break;
            }
        }
        if (isFailed)
        {
            result = "not pangram";
        }
        else
        {
            result = "pangram";
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

