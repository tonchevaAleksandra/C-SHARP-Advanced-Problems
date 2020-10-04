using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        keyboards.Where(x => x < b);
        drives.Where(x => x < b);
        int maxSum = 0;
       
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                int currSum = keyboards[i] + drives[j];
                if(currSum<=b && currSum>maxSum)
                {
                    maxSum = currSum;
                }
            }
        }
        if (maxSum==0)
        {
            return -1;
        }
        else
        {
            return maxSum;
        }

    }

    static void Main(string[] args)
    {
        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        Console.WriteLine(moneySpent);

    }
}
