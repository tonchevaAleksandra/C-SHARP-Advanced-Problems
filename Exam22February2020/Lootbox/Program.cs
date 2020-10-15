using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> first = new Queue<int>(Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray());

            Stack<int> second =new Stack<int>( Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray());

            var sum = 0;
            while (first.Any()&& second.Any())
            {
                var currSum = first.Peek() + second.Peek();
                if(currSum%2==0)
                {
                    first.Dequeue();
                    second.Pop();
                    sum += currSum;
                }
                else
                {
                    first.Enqueue(second.Pop());
                }
            }

            if (first.Any()) Console.WriteLine("Second lootbox is empty");
            else Console.WriteLine("First lootbox is empty");

            if (sum >= 100) Console.WriteLine($"Your loot was epic! Value: {sum}");
            else Console.WriteLine($"Your loot was poor... Value: {sum}");
        }
    }
}
