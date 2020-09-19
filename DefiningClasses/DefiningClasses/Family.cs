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

        public Person GetOldestMember()
        {
            Person oldestPerson = this.people
                .OrderByDescending(p=>p.Age)
                .FirstOrDefault();

            return oldestPerson;
        }


    }
}
