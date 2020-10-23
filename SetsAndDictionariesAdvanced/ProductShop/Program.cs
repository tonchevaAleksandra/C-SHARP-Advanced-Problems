using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{shop}, {product}, {price}".
            //"Revision" 
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arguments = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if(!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, 0);
                }
                shops[shop][product] = price;
            }

            foreach (var (key,value) in shops)
            {
                Console.WriteLine($"{key}->");
                foreach (var kvp in value)
                {
                    Console.WriteLine($"Product: { kvp.Key}, Price: { kvp.Value}");
                }
            }
        }
    }
}
