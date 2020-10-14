using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets1 = Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int[] targets = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Queue<int> bombEffects = new Queue<int>(targets1);
            Stack<int> bombCasing = new Stack<int>(targets);

            Dictionary<int, int> bombs = new Dictionary<int, int>();
            bombs.Add(40, 0);
            bombs.Add(60, 0);
            bombs.Add(120, 0);

            while(bombEffects.Any() && bombCasing.Any())
            {
                var currResult = bombEffects.Dequeue() + bombCasing.Peek();
                while (currResult>120 || (currResult>60 && currResult<120) || (currResult>40 && currResult<60))
                {
                    currResult -= 5;
                }
                if (bombs.Any(b => b.Key == currResult))
                { bombs[currResult]++; }

                    bombCasing.Pop();
               
               if(bombs.All(b=>b.Value>=3))
                {
                    break;
                }
            }

            Dictionary<string, Dictionary<int, int>> dict = new Dictionary<string, Dictionary<int, int>>();
            dict.Add("Datura Bombs", bombs.Where(b => b.Key == 40).ToDictionary(b => b.Key, b => b.Value));
            dict.Add("Cherry Bombs", bombs.Where(b => b.Key == 60).ToDictionary(b => b.Key, b => b.Value));
            dict.Add("Smoke Decoy Bombs", bombs.Where(b => b.Key ==120).ToDictionary(b => b.Key, b => b.Value));
            if (bombs.All(b=>b.Value>=3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if(bombEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if(bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            foreach (var item in dict.OrderBy(b => b.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()}");
            }
          
        }
    }
}
