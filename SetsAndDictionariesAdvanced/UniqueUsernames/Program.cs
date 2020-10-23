using System;
using System.Collections.Generic;
namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> users = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                users.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine,users));
        }
    }
}
