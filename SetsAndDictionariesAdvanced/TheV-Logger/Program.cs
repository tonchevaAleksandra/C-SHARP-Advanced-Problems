using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> data = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split();
                string vloggerName = tokens[0];
                string command = tokens[1];

                if (command == "joined")
                {
                    if (!data.ContainsKey(vloggerName))
                    {
                        data.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        data[vloggerName].Add("followers", new SortedSet<string>());
                        data[vloggerName].Add("following", new SortedSet<string>());
                    }

                }
                else
                {
                    string vloggerName2 = tokens[2];
                    if (data.ContainsKey(vloggerName) && data.ContainsKey(vloggerName2) && !vloggerName.Equals(vloggerName2))
                    {
                        data[vloggerName]["following"].Add(vloggerName2);
                        data[vloggerName2]["followers"].Add(vloggerName);
                    }
                }
            }
            data = PrintResults(data);
        }

        private static Dictionary<string, Dictionary<string, SortedSet<string>>> PrintResults(Dictionary<string, Dictionary<string, SortedSet<string>>> data)
        {
            Console.WriteLine($"The V-Logger has a total of {data.Keys.Count} vloggers in its logs.");


            data = data.OrderByDescending(x => x.Value["followers"].Count()).ThenBy(x => x.Value["following"].Count()).ToDictionary(x => x.Key, x => x.Value);

            var firstVlogger = data.Take(1);
            var app = data.TakeLast(data.Keys.Count - 1);
            foreach (var kvp in firstVlogger)
            {
                Console.WriteLine($"1. { kvp.Key} : { kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
                foreach (var item in kvp.Value["followers"])
                {
                    Console.WriteLine($"*  {item}");
                }
            }
            int count = 2;
            foreach (var kvp in app)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
                count++;
            }

            return data;
        }
    }
}
