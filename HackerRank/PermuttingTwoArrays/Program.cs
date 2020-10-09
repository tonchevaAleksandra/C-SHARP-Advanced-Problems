using System;
using System.Linq;

namespace PermutingTwoArrays
{
    class Program
    {
        static string twoArrays(int k, int[] A, int[] B)
        {
            A = A.OrderBy(x => x).ToArray();
            B = B.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]+B[i]<k)
                {
                    return "NO";
                }
            }
            return "YES";
        }
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
                ;

                int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
                ;
                string result = twoArrays(k, A, B);

                Console.WriteLine(result);
            }
        }
    }
}
