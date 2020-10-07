using System;
using System.Linq;

namespace Froggy
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Lake lake = new Lake(stones);
            //Lake lake = new Lake(new int[] { 1, 2, 3, 4, 5 });// this would work just with constructor with params
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
