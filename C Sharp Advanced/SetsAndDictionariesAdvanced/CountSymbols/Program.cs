using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> countChars = new SortedDictionary<char, int>();

            char[] characters = input.ToCharArray();

            foreach (var ch in characters)
            {
                if(!countChars.ContainsKey(ch))
                {
                    countChars.Add(ch, 0);
                }
                countChars[ch]++;
            }

            foreach (var (character,count) in countChars)
            {       
                Console.WriteLine($"{character}: {count} time/s");
            }
        }
    }
}
