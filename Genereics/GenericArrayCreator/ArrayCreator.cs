using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
   public class ArrayCreator/*<T>*/ // this will create a new class for everytime that we invoke the class with diff type and we are not allow to use the class in the main without describe the type
    {
        
        public static T[] Create<T>(int length, T item)// with T described here in the method, we create just one class in .dll and we are not obligated to write the type everytime we invoke it in the main
           // !!! But this is possible because we don't have another properties or methods that uses T in the class- we have just one method
        {
            var array = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}
