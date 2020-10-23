using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines1
{
    class Program
    {
        static void Main(string[] args)
        {
          using StreamReader reader = new StreamReader("./text.txt");
            int counter = 0;
            char[] characteresToReplace = new char[] { '-', ',', '.', '!', '?' };
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if(line == null)
                {
                    break;
                }
                if(counter%2==0)
                {
                    line = ReplaceAllPunctuation(characteresToReplace, '@', line);

                    line = ReverseWordsInText(line);

                    Console.WriteLine(line);
                }

                counter++;

            }
        }

        static string ReplaceAllPunctuation(char[] replace,char replacement,string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];
                if(replace.Contains(line[i]))
                {
                    sb.Append(replacement);
                }
                else
                {
                    sb.Append(currSymbol);
                }
            }
            return sb.ToString().TrimEnd();
        }

        static string ReverseWordsInText(string line)
        {

            
           StringBuilder sb = new StringBuilder();
            string[] words = line.Split()
                .ToArray();
            int wordsLen = words.Length;
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[wordsLen - i - 1] +" ");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
