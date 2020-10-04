
using System.Collections;
using System;

class Solution
{

    // Complete the icecreamParlor function below.
    static int[] icecreamParlor(int m, int[] arr)
    {
        var result = new int[2];
        var prices = new Hashtable();// Key=cost, value = index+1

        for (var i = 0; i < arr.Length; i++)
        {
            var diff = m - arr[i];
            if (prices[diff] != null)
            {
                result[0] = (int)prices[diff];
                result[1] = i + 1;

                break;
            }
            else if (!prices.ContainsKey(arr[i]))
            {
                prices.Add(arr[i], i + 1);
            }
        }

        return result;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = icecreamParlor(m, arr);

            Console.WriteLine(string.Join(" ", result));
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
