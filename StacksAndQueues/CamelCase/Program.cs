using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);

            Console.WriteLine(result);
        }
        static int camelcase(string s)
        {
            int sum = 1;
            int indexEnd = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]<91)
                {
                    
                    indexEnd = i;
                    break;
                }
            }
            if(indexEnd==0)
            {
                return sum;
            }
            else
            {
                string current = s.Substring(indexEnd);
                string patterns = @"[A-Z][a-z]*";
                MatchCollection matches = Regex.Matches(current, patterns);
                if (matches.Count>0)
                {
                    sum += matches.Count(); 
                }
            }
           

            return sum;
        }
    }
}
