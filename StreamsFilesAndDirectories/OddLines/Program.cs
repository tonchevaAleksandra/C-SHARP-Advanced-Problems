using System;
using System.IO;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            int counter = 0;

            while (true)
            {
                var line = reader.ReadLine();
                if(line==null/* || line== string.Empty*/)
                {
                    break;
                }
                if(counter%2==0)
                {
                    char[] arr = new char[] { '-', ',', '.', '!', '?' };
                    char[] arrToReplace = new char[] { '@' };
                    string result = new string(line).Replace("-","@");
                    result = result.Replace(",", "@");
                    result = result.Replace(".", "@");
                    result = result.Replace("!", "@");
                    result = result.Replace("?", "@");
                    string[] arr3 = result.Split();
                    Array.Reverse(arr3);
                    Console.WriteLine(string.Join(" ",arr3));
                }
                counter++;

            }
        }
    }
}
