using System;
using System.Collections.Generic;
using System.Linq;


namespace DefiningClasses
{
    public class Family
    {
        private HashSet<Person> people;

        public Family()
        {
            this.people = new HashSet<Person>();
        }


        public void AddMamber(Person person)
        {
            this.people.Add(person);
        }

        public HashSet<Person> GetPeopleAbove30()
        {
            return people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToHashSet();
        }


    }
}
