using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int barrelsSize = int.Parse(Console.ReadLine());

            int[] arr1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Stack<int> bullets = new Stack<int>(arr1);

            int[] arr2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Queue<int> locks = new Queue<int>(arr2);
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int countBullets = 0;

            while (locks.Any() && bullets.Any())
            {

                if (locks.Peek() >= bullets.Peek())
                {
                    Console.WriteLine("Bang!");

                    bullets.Pop();
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                countBullets++;
                if (countBullets % barrelsSize == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            PrintResult(priceBullet, bullets, locks, valueOfIntelligence, countBullets);
        }

        private static void PrintResult(int priceBullet, Stack<int> bullets, Queue<int> locks, int valueOfIntelligence, int countBullets)
        {
            if (bullets.Count < locks.Count)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else if (locks.Count == 0)
            {
                int moneyEarned = valueOfIntelligence - (priceBullet * countBullets);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
