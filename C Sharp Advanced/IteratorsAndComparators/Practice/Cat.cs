using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  public  class Cat:IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Move(int x, int y)
        {
            Console.WriteLine("Cat moved");
        }
    }
}
