using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class NumbersEnumerator : INumberEnumerator
    {
        private List<int> list;
        private int index;
        public List<int> Data
        {
            get
            {
                if(this.list==null)
                {
                    throw new Exception("Data must be set before calling foreach.");
                }
                return this.Data;
            }
            set
            {
                this.list = value;
            }
        }

        public NumbersEnumerator()
        {
            this.Reset();
            
        }
        public int Current
        {
            get
            {
                return this.Data[this.index];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            this.index++;

            return this.index < this.Data.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
