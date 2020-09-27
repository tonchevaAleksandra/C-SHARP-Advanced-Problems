using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementingStackTemplate
{
    public class MyStack<T> :IEnumerable<T>
    {
        private int capacity;
        private T[] data;
        public MyStack()
            : this(4)
        {

        }

        public MyStack(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }
        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = element;

            this.Count++;
        }
        public T Pop()
        {
            this.ValidateEmptyStack();
            var result = this.data[this.Count - 1];
            this.Count--;

            return result;
        }

        private void ValidateEmptyStack()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
        }

        public T Peek()
        {
            this.ValidateEmptyStack();

            return this.data[this.Count - 1];
        }
        public void Clear()
        {
            this.data = new T[capacity];
            this.Count = 0;
        }

        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new T[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        private void Foreach(Action<T> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
       => this.data
            .Take(this.Count)
            .Reverse()
            .ToList()
            .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}
