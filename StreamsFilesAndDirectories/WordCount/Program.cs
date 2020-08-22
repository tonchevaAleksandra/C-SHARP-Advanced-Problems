using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
           using var reader = new StreamReader("words.txt");


            var words = new List<string>();
            while (true)
            {
                var line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                words.Add(line);
            }

            using var readText = new StreamReader("text.txt");
            char[] sepatators = new char[] { '-', '.', ',', '?', '!', ' ' };
            var text = new List<string>();
            while (true)
            {
                var line = readText.ReadLine();
                if(line==null)
                {
                    break;
                }
                text.AddRange(line.ToLower().Split(sepatators,StringSplitOptions.RemoveEmptyEntries));
            }

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        
            foreach (var item in words)
            {
                wordsCount.Add(item, 0);
                while (text.Contains(item))
                {
                    wordsCount[item]++;
                   text.RemoveAt(text.IndexOf(item));
                }
            }

            using var writerActual = new StreamWriter("actualResult.txt");

            foreach (var kvp in wordsCount)
            {
                writerActual.WriteLine($"{kvp.Key}-{kvp.Value}");
            }

            using var writeExpected = new StreamWriter("expectedResult.txt");
            foreach (var item in wordsCount.OrderByDescending(x=>x.Value))
            {
                writeExpected.WriteLine($"{item.Key}-{item.Value}");
            }
           
        }
    }
}
