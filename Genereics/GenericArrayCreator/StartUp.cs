using System;

namespace GenericArrayCreator
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var strings = ArrayCreator.Create(5, "Pesho");
            var integers = ArrayCreator.Create(10, 33);
            var characters = ArrayCreator.Create(5, 's');

        }
    }
}
