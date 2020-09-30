
using System;

class Solution
{

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if ((v2 - v1 != 0) && (x1 - x2) % (v2 - v1) == 0 && (x2 - x1) * (v2 - v1) < 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
