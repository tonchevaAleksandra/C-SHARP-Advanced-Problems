using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string a = s.Substring(0, 1);
        string b = s.Substring(1, 1);
        int[] hour = new int[2];
        hour[0] = int.Parse(a);
        hour[1] = int.Parse(b);
        StringBuilder r = new StringBuilder();

        string lastIndicator = s.Substring(8,1);
        switch (lastIndicator)
        {
            case "A":
               if(hour[0]==1 && hour[1]==2)
                {
                    r.Append("00");
                    r.Append(s.Substring(2, 6));
                }
                else
                {
                    r.Append(s.Substring(0, 8));
                }
                break;
            case "P":
                if(hour[0] == 0)
                {
                    int numH = hour[1] + 12;
                    r.Append(numH.ToString());
                    r.Append(s.Substring(2, 6));
                }
                else if(hour[0]==1 && hour[1]==1)
                {
                    r.Append("23");
                    r.Append(s.Substring(2, 6));
                }
                else
                {
                    r.Append(s.Substring(0, 8));
                }
                break;
           
        }
        return r.ToString();
    }

    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);

        //tw.Flush();
        //tw.Close();
    }
}
