using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ImplementingListTemplate
{
    public class MyList<T> : IEnumerable<T>
    {
        private int capacity;
        private T[] data;

        public MyList()
            : this(4)
        {

        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }
        public int Count { get; private set; }
        public void Add(T number)
        {
            this.CheckIfResizeIsNeeded();
            this.data[this.Count] = number;
            this.Count++;
        }


        public void Insert(int index, T element)
        {
            this.CheckIfResizeIsNeeded();
            if (index == this.Count)
            {
                this.Add(element);
            }
            else
            {
                this.ValidateIndex(index);

                for (int i = this.Count - 1; i >= index; i--)
                {
                    this.data[i + 1] = this.data[i];
                    ;
                }

                this.data[index] = element;
                this.Count++;
            }


        }
        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);
            var result = this.data[index];
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }

            this.Count--;

            return result;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
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
        public T this[int index]// indexator
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }

        private void ValidateIndex(int index)
        {

            if (index >= 0 && index < this.Count)
            {
                return;
            }

            var message = this.Count == 0
                ? "The list is empty"
                : $"The list has {this.Count} elements and it is zero-based";

            throw new Exception($"Index out of range. {message}");

        }
        public int RemoveAll(Func<T, bool> filter)
        {
            var removed = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (filter(this.data[i]))
                {
                    this.RemoveAt(i);
                    removed++;
                }
            }

            return removed;

        }
        public void Clear()
        {
            this.Count = 0;
            this.data = new T[capacity];
        }

        public bool TrueForAll(Func<T, bool> predicate)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (!predicate(this.data[i]))
                {
                    return false;
                }
            }

            return true;
        }
        private void CheckIfResizeIsNeeded()
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
        }

        public IEnumerator<T> GetEnumerator()
             => /*(IEnumerator<T>)*/this.data
            .Take(this.Count)
            .ToList()
            .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
             => this.GetEnumerator();
    }
}
