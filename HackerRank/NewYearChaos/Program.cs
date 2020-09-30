
using System;

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int totalBribes = 0;
        int expectedCurrent = 1;
        int expectedSecond = 2;
        int expectedThird = 3;
        for ( int i = 0; i < q.Length; i++)
        {
            if (q[i] == expectedCurrent)
            {
                expectedCurrent = expectedSecond;
                expectedSecond = expectedThird;
                expectedThird++;
            }
            else if (q[i] == expectedSecond)
            {
                totalBribes++;
                expectedSecond = expectedThird;
                expectedThird++;
            }
            else if (q[i] == expectedThird)
            {
                totalBribes += 2;
                expectedThird++;
            }
            else
            {
                Console.WriteLine("Too chaotic");  
                return;
            }
        }
        Console.WriteLine(totalBribes);

    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
