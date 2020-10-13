using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] targets1 = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int[] targets2 = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Stack<int> lilies = new Stack<int>(targets1);
            Queue<int> roses = new Queue<int>(targets2);
            List<int> rest = new List<int>();
            int count = 0;

            for (int i = 0; i < targets2.Length; i++)
            {
                var result = lilies.Pop() + roses.Dequeue();
                while (result > 15)
                {
                    result -= 2;
                }
                if (result == 15)
                {
                    count++;
                }
                else if (result < 15)
                {
                    rest.Add(result);
                }

            }

            if(rest.Sum()>15)
            {
                count += rest.Sum() / 15;
            }
            if(count>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {count} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-count} wreaths more!");
            }
        }
    }
}
