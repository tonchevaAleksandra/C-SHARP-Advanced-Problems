using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {

                string[] inputArgs = Console.ReadLine()
           .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
           .ToArray();
                string color = inputArgs[0];
                string[] currentClothes = inputArgs[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in currentClothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }


            string[] clothesToFind = Console.ReadLine()
           .Split()
           .ToArray();
            string toFindColor = clothesToFind[0];
            string pieceOfClothing = string.Empty;
            if (wardrobe.ContainsKey(toFindColor))
            {
                if (wardrobe[toFindColor].ContainsKey(clothesToFind[1]))
                {
                    pieceOfClothing = clothesToFind[1];
                }
            }
            string result = string.Empty;
            result = PrintResult(wardrobe, toFindColor, pieceOfClothing, result);
        }

        private static string PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string toFindColor, string pieceOfClothing, string result)
        {
            foreach (var kvp in wardrobe)
            {

                Console.WriteLine($"{ kvp.Key} clothes:");
                foreach (var cloth in kvp.Value)
                {
                    if (cloth.Key == pieceOfClothing && kvp.Key == toFindColor)
                    {
                        result = $" (found!)";
                    }
                    Console.WriteLine($"* { cloth.Key} - { cloth.Value}" + result);
                    result = string.Empty;
                }
            }

            return result;
        }
    }
}
