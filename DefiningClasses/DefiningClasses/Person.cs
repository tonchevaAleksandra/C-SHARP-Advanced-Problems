using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Person
    {
       
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private int age;

        public int Age
        {
            get { return this.age; } // if a private field is make => if no private field we can use just ge;set;
            set { this.age = value; }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            :this()
        {
            this.Age = age;
        }
          public Person(string name,int age)
            :this(age)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}"; 
        }
    }
}
