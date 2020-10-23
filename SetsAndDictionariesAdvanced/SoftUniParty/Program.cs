using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

           HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();


            string input;
            while ((input=Console.ReadLine())!="END")
            {

                if (input == "PARTY")
                {
                    string commingGuest = Console.ReadLine();
                    while (commingGuest != "END")
                    {
                        if (vipGuests.Contains(commingGuest))
                        {
                            vipGuests.Remove(commingGuest);
                        }
                        else if (regularGuests.Contains(commingGuest))
                        {
                            regularGuests.Remove(commingGuest);
                        }
                        commingGuest = Console.ReadLine();
                    }
                    break;
                }
                else
                {
                    string pattern = @"[0-9](.){7,}";
                    Match match = Regex.Match(input, pattern);
                    if (match.Success)
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                } 
            }

            int countAbsentGuests = regularGuests.Count + vipGuests.Count;
            Console.WriteLine(countAbsentGuests);
            if (vipGuests.Any())
            {
                foreach (var item in vipGuests)
                {
                    Console.WriteLine(item);
                } 
            }
            if (regularGuests.Any())
            {
                foreach (var item in regularGuests)
                {
                    Console.WriteLine(item);
                } 
            }
        }
    }
}
