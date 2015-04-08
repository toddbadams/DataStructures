using System;

namespace tba.DataStructures.Collections
{

    public class ArrayStack<T> : tba.DataStructures.Collections.IStack<T>
    {
        private T[] stack;

        public ArrayStack()
        {
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (stack == null)
            {
                this.Count = 1;
                stack = new T[1];
            }
            else
            {
                this.Count++;
                Array.Resize(ref stack, this.Count);
            }
            this.stack[this.Count-1] = element;
        }

        public T Pop()
        {
            if (this.Count < 1) throw new InvalidOperationException();
            this.Count--;
            T returnedItem = this.stack[this.Count];
            Array.Resize(ref stack, this.Count);
            return returnedItem;
        }

        public T Peek()
        {
            return this.stack[this.Count-1];
        }
    }

}
