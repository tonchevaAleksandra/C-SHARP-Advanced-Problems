using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
   public class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            Type typeOfT = typeof(T);
            return typeOfT.FullName + ": " + this.Value.ToString();
        }
    }
}
