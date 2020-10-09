using System;
using System.Text;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void decentNumber(int n)
        {

            int m = n;
            while (m % 3 != 0)
            {
                m -= 5;
            }
            if (m < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(new string('5', m) + new string('3', (n - m)));
            }
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                decentNumber(n);
            }
        }
    }
}

