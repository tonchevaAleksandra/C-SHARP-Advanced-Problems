using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> people = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person currPerson = new Person(name, age);
                sortedPeople.Add(currPerson);
                people.Add(currPerson);

            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(people.Count);
        }
    }
}
