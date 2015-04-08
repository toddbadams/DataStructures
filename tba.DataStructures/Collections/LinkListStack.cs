using System;
using System.Collections.Generic;

namespace tba.DataStructures.Collections
{
    public class LinkListStack<T> : tba.DataStructures.Collections.IStack<T>
    {
        class Node<T>
        {
            public T Value { get; private set; }
            public Node<T> Next { get; private set; }

            public Node(T value, Node<T> next)
            {
                this.Value = value;
                this.Next = next;
            }
        }

        private Node<T> first;

        public LinkListStack()
        {
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T value)
        {
            this.first = new Node<T>(value, this.first);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count < 1) throw new InvalidOperationException();

            T returnedItem = this.first.Value;
            this.first = this.first.Next;
            this.Count--;
            return returnedItem;
        }

        public T Peek()
        {
            return this.first.Value;
        }
    }

}
