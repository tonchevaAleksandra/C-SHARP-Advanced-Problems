using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
   public class Numbers:IEnumerable<int>
    {
        private List<int> data;
        private INumberEnumerator enumerator;
        
        public int Count => this.data.Count;//get

        public Numbers(List<int> numbers, INumberEnumerator enumerator)
        {
            this.data = numbers;
            this.enumerator = enumerator;
            this.enumerator.Data = this.data;
        }
        public Numbers(List<int> numbers)
            :this(numbers, new NumbersEnumerator())
        {
            this.data = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
           return (IEnumerator<int>)this.enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();//return the other method
        }
    }
}
