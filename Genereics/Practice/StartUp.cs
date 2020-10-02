using System;
using System.Collections.Generic;

namespace Practice
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Ivaylo";
            var dog = new Dog();
            dog.Name = "Kenov";

            var animals = new List<Animal>();
            animals.Add(new Cat { Name = "Ivan" });
            animals.Add(new Dog { Name = "Gosho" });
            animals.Add(new Bunny { Name = "Pesho" });

            foreach (var animal in animals)
            {
                //if(animal is Cat )
                //{
                //    Console.WriteLine(cat.SayHello());
                //}
                Console.WriteLine(animal.Name);
            }
        }
    }
}
