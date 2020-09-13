using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lines= File.ReadAllLines("./text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];

                int letters = CountLettersInLine(currLine);
                int punctuationSymbols = CountPunctuationSymbols(currLine);
                lines[i] = $"Line {i + 1}: {lines[i]} ({letters})({punctuationSymbols})";

               
            }
            File.WriteAllLines("../../../output.txt", lines);
        }

        static int CountLettersInLine(string currLine)
        {
            string pattern = @"[A-Za-z]";
            MatchCollection matches = Regex.Matches(currLine, pattern);
            return matches.Count;
        }

        static int CountPunctuationSymbols(string currLine)
        {
            string pattern = @"[\-\.\,\'\?\!]";
            MatchCollection matches = Regex.Matches(currLine, pattern);
            return matches.Count;
        }
    }
}
