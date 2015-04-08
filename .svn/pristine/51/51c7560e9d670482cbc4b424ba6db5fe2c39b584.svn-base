using System;
using System.Collections.Generic;

namespace tba.DataStructures.Collections
{

    public class CollectionStack<T> : tba.DataStructures.Collections.IStack<T>
    {
        private Stack<T> stack;

        public CollectionStack()
        {
            stack = new Stack<T>();
        }

        public int Count { get { return stack.Count; } }

        public void Push(T element)
        {
            this.stack.Push(element);
        }

        public T Pop()
        {
            return this.stack.Pop();
        }

        public T Peek()
        {
            return this.stack.Peek();
        }
    }

}
