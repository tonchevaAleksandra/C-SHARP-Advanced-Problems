using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {

        public List<T> Data { get; set; }

        public CustomStack()
        {
            this.Data = new List<T>();
        }
        public void Push(T item)
        {
           this.Data.Add(item);
        }
        public T Pop()
        {
            
           if(this.Data.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var item = this.Data[this.Data.Count - 1];
            this.Data.RemoveAt(this.Data.Count - 1);
            return item;
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Data.Count - 1; i >=0; i--)
            {
                yield return this.Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
