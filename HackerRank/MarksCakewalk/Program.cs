using System;
using System.Linq;

namespace MarksCakewalk
{
    class Program
    {
        static long marcsCakewalk(int[] calorie)
        {
           calorie = calorie.OrderByDescending(x => x).ToArray();
           long result = 0;
            for (int i = 0; i < calorie.Length; i++)
            {
                var power = Math.Pow(2, i);
                result += (long)((power) * calorie[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp))
            ;
            long result = marcsCakewalk(calorie);

            Console.WriteLine(result);
        }
    }
}
