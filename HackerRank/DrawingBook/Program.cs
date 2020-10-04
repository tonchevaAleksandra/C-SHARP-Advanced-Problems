using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int pageCount(int n, int p)
    {
        int count = Math.Min(p / 2, n / 2 - p / 2);

        return count;
    }

    static void Main(string[] args)
    {
       
        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        Console.WriteLine(result);

    }
}
