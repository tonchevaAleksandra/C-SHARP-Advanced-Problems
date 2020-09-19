using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private /*readonly*/ HashSet<Person> people;

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
