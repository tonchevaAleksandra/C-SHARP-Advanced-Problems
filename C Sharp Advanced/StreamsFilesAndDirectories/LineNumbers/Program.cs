using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            using StreamWriter writer = new StreamWriter("output.txt",true);//it stays if false don't saves the changes just run it at the moment

            int count = 1;

            while (true)
            {
                var line = reader.ReadLine();
                if(line==null)
                {
                    break;
                }

                string patternLetters = @"[A-Za-z]";
                MatchCollection letters = Regex.Matches(line, patternLetters);
                string patternPunctuation = @"[\.\,\!\?\-\']";
                MatchCollection punctuations = Regex.Matches(line, patternPunctuation);
                var convertedLine = $"Line{count}:{line} ({letters.Count})({punctuations.Count})";

                writer.WriteLine(convertedLine);
                count++;
            }
                                                         
        }
    }
}
