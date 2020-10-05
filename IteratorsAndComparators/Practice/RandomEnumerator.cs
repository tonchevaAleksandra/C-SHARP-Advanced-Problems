using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class RandomEnumerator : INumberEnumerator
    {
        private Random random;
        private List<int> list;
        public RandomEnumerator()
        {  
            this.random = new Random();
        }
        public List<int> Data
        {
            get
            {
                if (this.list == null)
                {
                    throw new Exception("Data must be set before calling foreach.");
                }
                return this.list;
            }
            set
            {
                this.list = value;
            }
        }
        public int Current
        {
            get
            {
                var randomIndex = this.random.Next(0, this.Data.Count);
                return this.Data[randomIndex];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            int toMove = this.random.Next(0, 10);
            return toMove !=0;
        }

        public void Reset()
        {
            
        }
    }
}
