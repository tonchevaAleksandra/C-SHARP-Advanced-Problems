using System;

namespace BeautifullDaysAtTheMovies
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            var result = 0;
            for (int day = i; day <= j; day++)
            {
                var currNum = day;
                var secondNum = 0;
                while (currNum>0)
                {
                    secondNum = secondNum * 10 + (currNum % 10);
                    currNum /=10;
                }
                if(Math.Abs(day-secondNum) % k == 0)
                {
                    result ++;
                }

            }
            return result;

        }
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);

        }
    }
}
