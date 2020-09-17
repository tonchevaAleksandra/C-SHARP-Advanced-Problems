using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        { 

            var guests = Console.ReadLine()
                .Split()
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command.Split().ToArray();
                string cmdType = cmdArgs[0];
                string[] predicateArgs = cmdArgs
                    .Skip(1)
                    .ToArray();

                Predicate<string> predicate = GetPredicate(predicateArgs);

                if (cmdType == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (cmdType == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        string currGuest = guests[i];
                        if (predicate(currGuest))
                        {
                            guests.Insert(i + 1, currGuest);
                            i++;
                        }
                    }
                }
            }

            if(guests.Count>0)
            {
                string result = string.Join(", ", guests);
                Console.WriteLine($"{result} are going to the party!");
            }

            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }     

        static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            string prType = predicateArgs[0];
            string prArg = predicateArgs[1];

            Predicate<string> predicate = null;

            if (prType == "StartsWith")
            {
                predicate = new Predicate<string>(name => name.StartsWith(prArg));

            }

            else if (prType == "EndsWith")
            {
                predicate = new Predicate<string>(name => name.EndsWith(prArg));

            }

            else if (prType == "Length")
            {
                predicate = new Predicate<string>(name => name.Length == int.Parse(prArg));

            }

            return predicate;

        }
    }
}
