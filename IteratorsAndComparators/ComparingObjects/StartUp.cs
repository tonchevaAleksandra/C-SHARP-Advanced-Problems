using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Person> people = new List<Person>();
            while ((input=Console.ReadLine())!="END")
            {
                string[] personInfo = input.Split().ToArray();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];
                Person currPerson = new Person(name, age, town);
                people.Add(currPerson);

            }

            int n = int.Parse(Console.ReadLine());
            Person personToCompare = people[n - 1];

           
            int matchesCount = 0;

            foreach (Person person in people)
            {
                if(person.CompareTo(personToCompare)==0)
                {
                    matchesCount++;
                }
            }
            if (matchesCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{ matchesCount} {people.Count-matchesCount} {people.Count}");
            }
        }
    }
}
