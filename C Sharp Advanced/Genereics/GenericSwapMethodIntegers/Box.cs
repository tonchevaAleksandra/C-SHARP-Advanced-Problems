using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
      
        public List<T> Data { get; set; }
     
        public Box(List<T> data)
        {
            this.Data = data;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Data)
            {
                sb.AppendLine(item.GetType() + ": " + item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.Data[firstIndex];
            this.Data[firstIndex] = this.Data[secondIndex];
            this.Data[secondIndex] = temp;
            
        }
    }
}
