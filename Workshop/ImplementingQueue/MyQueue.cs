using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementingQueue
{
    public class MyQueue<T>:IEnumerable<T>
    {
        private int capacity;
        private T[] data;

        public MyQueue()
           : this(4)
        {

        }

        public MyQueue(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }

        public int Count{ get; private set; }
        public MyQueue(T[] collection):
            this(collection.Length)
        {

            foreach (var item in collection)
            {
                this.Enqueue(item);
            }
        }
        public void Enqueue(T element)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = element;

            this.Count++;
        }

        public T Dequeue()
        {
            this.ValidateIfQueueIsEmpty();
            var currElement = this.data[0];
            this.Count--;
            return currElement;
        }

        public T Peek()
        {
            this.ValidateIfQueueIsEmpty();

            return this.data[0];

        }
        public void Clear()
        {
            this.Count = 0;
            this.data = new T[capacity];
        }

        public void ValidateIfQueueIsEmpty()
        {
            if(this.Count==0)
            {
                throw new InvalidOperationException("The queue is empty. You can not make this operation on an empty queue!");
            }
        }

        public void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new T[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public bool Contains(T element)
        {
            this.ValidateIfQueueIsEmpty();
            foreach (var item in this.data)
            {
                if(item.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public T[] ToArray()
        {
            return this.data;
        }

        public void Foreach(Action<T> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.data[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        => this.data
            .Take(this.Count) 
            .ToList()
            .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
       => this.GetEnumerator();


        public override string ToString()
        {
            return this.data.ToString(); 
        }
    }
}
