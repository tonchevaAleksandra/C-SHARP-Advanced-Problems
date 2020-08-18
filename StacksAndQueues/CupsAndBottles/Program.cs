using System;
using System.Linq;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int[] arr2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Queue<int> cups = new Queue<int>(arr1);
            Stack<int> bottles = new Stack<int>(arr2);
            int wastedWater = 0;

            while(cups.Count>0 && bottles.Count>0)
            {
               
                if (bottles.Peek() >=cups.Peek())
                {
                    wastedWater += (bottles.Pop() - cups.Dequeue());
                }
                else
                {
                    int currentCup = cups.Dequeue();
                   currentCup -= bottles.Pop();
                    List<int> curr = cups.ToList();               
                    curr.Insert(0, currentCup);
                    cups = new Queue<int>(curr);
                  
                }
            }

            Console.WriteLine(cups.Count()>0 ? $"Cups: { string.Join(" ",cups)}": $"Bottles: {string.Join(" ",bottles)}");

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
