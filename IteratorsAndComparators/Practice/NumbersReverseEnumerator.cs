using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
   public class NumbersReverseEnumerator:INumberEnumerator
    {
        private List<int> list;
        private int index;
        public NumbersReverseEnumerator()
        {
            this.Reset();
            
           
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
                return this.Data[index];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            this.index--;
            return this.index >= 0;
        }

        public void Reset()
        {
            this.index=this.Data.Count;
        }
    }
}
