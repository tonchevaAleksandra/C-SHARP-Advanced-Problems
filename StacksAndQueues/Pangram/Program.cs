using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = pangrams(s);

            Console.WriteLine(result);

            //Console.Flush();
            //textWriter.Close();
        }
        static string pangrams(string s)
        {
            string result = string.Empty;
            s = s.ToLower();
            Queue<char> queue = new Queue<char>();
            for (int i = 97; i < 123; i++)
            {
                char current = (char)i;
                queue.Enqueue(current);
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

    }
}
