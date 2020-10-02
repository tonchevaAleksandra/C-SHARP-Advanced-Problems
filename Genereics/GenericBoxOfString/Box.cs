using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
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
            //"{class full name: value}"
            return this.Value.GetType()+": "+this.Value.ToString(); 
        }
    }
}
