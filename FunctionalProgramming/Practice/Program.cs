using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static int someNumber = 5; // declaring a variable to use it for more then one methods
        //this is a state
        //pure function can not 
        static void Main(string[] args)
        {
            Console.WriteLine(someNumber);
            int x = someNumber + 1;
            int y = someNumber * 2;
            int sum = Sum(x,y);
            Console.WriteLine(sum);
            //Cat.Name - it's not available because we have to make an object of this class, it's not stqatic
            var cat = new Cat();
            var name = cat.Name;

            
        }

        static int Sum(int x, int y)=>someNumber + x + y;
       
        static List<int> SumArray(int[] numbers) //this is a pure function - the function will not manipulate the input int[] numbers
        {
            return new List<int>(numbers)
            {
                5,6,7
            };
        }
    }


    public class Cat
    {
        public string Name { get; set; } //when the data is not static - data can not be used from Main (p.example) without create an object of the same class
        //when is static you can use the data from the class in other Methods without create an object of the class
      

        public bool IsAwake { get; set; }

        public void GoSleep() // behaviour
        {
            this.IsAwake = true;
        }

        public string SayHello()//avoid state
        {
            return "Mew";
        }
    }
}
