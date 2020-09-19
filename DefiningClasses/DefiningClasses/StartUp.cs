using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currPerson = new Person(name, age);
                family.AddMamber(currPerson);
            }
 
            Console.WriteLine(family.GetOldestMember().ToString());
        }
    }
}
