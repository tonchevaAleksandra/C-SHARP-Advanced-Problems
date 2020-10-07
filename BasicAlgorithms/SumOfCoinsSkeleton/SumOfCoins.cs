using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = Console.ReadLine()
                .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .Select(int.Parse)
                .ToArray();
        var targets = Console.ReadLine()
            .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();
        var targetSum = targets[0];
        if (availableCoins.Where(x => x == 1 || x == 2 || x == 5 || x == 10 || x == 20 || x == 50).Count() == 0)
        {
            Console.WriteLine("Error");
            return;
        }

        var selectedCoins = ChooseCoins(availableCoins, targetSum);
        if(selectedCoins.Count()==0)
        {
            Console.WriteLine("Error");
            return;
        }
        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }


    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        var sortedCoins = coins.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < sortedCoins.Length; i++)
        {
            var currentCoin = sortedCoins[i];
            var totalCurrentCoins = targetSum / currentCoin;
            if (totalCurrentCoins == 0)
            {
                continue;
            }
            targetSum %= currentCoin;
            result[currentCoin] = totalCurrentCoins;

        }
        return result;



    }
}