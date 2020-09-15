using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var personArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = personArgs[0],
                    Age = int.Parse(personArgs[1])
                };

                people.Add(person);
            }

            var filter = Console.ReadLine();

            var ages = int.Parse(Console.ReadLine());

            Func<Person, bool> myFilter = filter switch
            {
                "older" => p => p.Age >= ages,
                "younger" => p => p.Age < ages,
                _ => p => true
            };

            var outputFormat = Console.ReadLine();

            Func<Person, string> outputFunc = outputFormat switch
            {
                "name age" => p => $"{p.Name} - {p.Age}",
                "name" => p => p.Name,
                "age" => p => p.Age.ToString(),
                _ => null
            };


            var sortingFormat = Console.ReadLine();

            //Func<Person, object> sortFunc = sortingFormat switch
            //{
            //    "name" => p => p.Name,
            //    "age" => p => p.Age,
            //    _ => p => p

            //};  - That will not work now for OrderBy function

            var sortFunc = sortingFormat switch
            {
                "name" => people.OrderBy(p => p.Name),
                "age" => people.OrderBy(p => p.Age),
                _ => people.OrderBy(p=>p)
            };


            people
                .Where(myFilter)
                .Select(outputFunc)
                .ToList()
                .ForEach(Console.WriteLine);


            //Func<Person, bool> myFilter= person=>true;
            //if (filter == "older")
            //{
            //    myFilter = p => p.Age > ages;
            //}
            //else
            //{
            //    myFilter = p => p.Age < ages;
            //}

            //people = people.Where(myFilter).ToList();

            //Func<Person, bool> doFilter = filter switch
            //{
            //    "older" => p => p.Age > ages,
            //    "younger" => p => p.Age < ages,
            //   _ => null
            //};



        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
