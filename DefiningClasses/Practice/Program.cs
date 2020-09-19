using System;

namespace Practice
{
   public class Program
    {
       public static void Main(string[] args)
        {
            //var cat = new// creating object without class 
            //{
            //    Name="Pesho",
            //    Age= 10
            //};

            //var dog = new
            //{
            //    Name = "Ivan",
            //    Breed = "Street"
            //};

            //// with defining anonymous type object without class do not give us an options to create many objects with the same data, or to create a behaviour with a method like in defined classes
            ////=> that not give us a template

            //Console.WriteLine("I have a cat "+cat.Name+" and a dog "+dog.Name);

            var cat = new Cat
            {
                Name = "Pesho",
                Age = 10,
                Color = "Grey"
            };

            cat.KillMouse();

            //cat.GoToSleep(); => does not work becaus the Method is private
        }
    }

   
}
