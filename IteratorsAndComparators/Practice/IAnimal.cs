using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
   public interface IAnimal
    {
        //every property here is public and every other object using this interface have to own the same public properties ot methods like those implemented in the interface
        string Name { get; }
        void Move(int x, int y);
    }
}
