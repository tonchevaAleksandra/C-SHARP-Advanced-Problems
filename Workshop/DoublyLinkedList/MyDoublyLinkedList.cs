

using System;

namespace DoublyLinkedList
{
    public class MyDoublyLinkedList
    {
        private ListNode<int> head;
        private ListNode<int> tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<int>(element); //that sets the both with the same instance
              
            }
            else
            {
                ListNode<int> newHead = new ListNode<int>(element);
                ListNode<int> oldHead = this.head;

                this.head = newHead;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;
            }

            this.Count++;
        }

        public void AddLast(int element)
        {
            if(this.Count==0)
            {
                this.head = this.tail = new ListNode<int>(element);
            }
            else
            {
                var oldTail = this.tail;
                var newTail = new ListNode<int>(element);
                oldTail.NextNode = newTail;
                newTail.PreviousNode = oldTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            //int? result = this.head?.Value;

            this.CheckCount();
            var result = this.head.Value;
            if(this.Count==1)
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

        public int RemoveLast()
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

        public void Foreach(Action<int> action)
        {
            var currentNode = this.head;
            while (currentNode!=null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            var arr = new int[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode!=null)
            {
                arr[counter++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }
    }
}
