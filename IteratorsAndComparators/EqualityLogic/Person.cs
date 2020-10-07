
using System;
using System.Diagnostics.CodeAnalysis;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int result = 1;
            if (other != null)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Age.CompareTo(other.Age);
                }
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return this.CompareTo(person) == 0;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode()+this.Age.GetHashCode();

        }
    }
}
