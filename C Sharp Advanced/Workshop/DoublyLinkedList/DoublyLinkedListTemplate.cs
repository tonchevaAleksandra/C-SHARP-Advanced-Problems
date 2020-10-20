using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
   public class DoublyLinkedListTemplate<T> :IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        
        public T this[int index]
        {
            get
            {
                T[] arr = this.ToArray();
                if(index<0 || index>=arr.Length)
                {
                    throw new ArgumentException("Index out of range!", nameof(index));
                }
                return arr[index];
            }
        }
        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element); //that sets the both with the same instance

            }
            else
            {
                ListNode<T> newHead = new ListNode<T>(element);
                ListNode<T> oldHead = this.head;

                this.head = newHead;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element);
            }
            else
            {
                var oldTail = this.tail;
                var newTail = new ListNode<T>(element);
                oldTail.NextNode = newTail;
                newTail.PreviousNode = oldTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            //int? result = this.head?.Value;

            this.CheckCount();
            var result = this.head.Value;
            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                var oldHead = this.head;
                var newHead = oldHead.NextNode;
                newHead.PreviousNode = null;
                this.head = newHead;

            }

            this.Count--;

            return result;

        }

        public T RemoveLast()
        {
            //int? result = this.tail?.Value;
            CheckCount();
            var result = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;

            return result;
        }

        private void CheckCount()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
        }

        public void ForЕach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                arr[counter++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //logic for the foreach loop
            var currentNode = this.head;
            while (currentNode!=null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
    }
}
