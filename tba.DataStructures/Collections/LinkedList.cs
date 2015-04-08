using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tba.DataStructures.Collections
{
    public class LinkedList<T> : tba.DataStructures.Collections.ILinkedList<T>
    {
        public LinkedList()
        {
            this.Count = 0;
            this.First = null;
        }

        // Summary:
        //     Gets the number of nodes actually contained in the System.Collections.Generic.LinkedList<T>.
        //
        // Returns:
        //     The number of nodes actually contained in the System.Collections.Generic.LinkedList<T>.
        public int Count { get; private set; }

        //
        // Summary:
        //     Gets the first node of the System.Collections.Generic.LinkedList<T>.
        //
        // Returns:
        //     The first System.Collections.Generic.LinkedListNode<T> of the System.Collections.Generic.LinkedList<T>.
        public LinkedListNode<T> First { get; private set; }

        //
        // Summary:
        //     Adds a new node containing the specified value at the start of the System.Collections.Generic.LinkedList<T>.
        //
        // Parameters:
        //   value:
        //     The value to add at the start of the System.Collections.Generic.LinkedList<T>.
        //
        // Returns:
        //     The new System.Collections.Generic.LinkedListNode<T> containing value.
        public LinkedListNode<T> AddFirst(T value)
        {
            this.First = new LinkedListNode<T>(value, this.First);
            this.Count++;
            return this.First;
        }

        //
        // Summary:
        //     Removes the node at the start of the System.Collections.Generic.LinkedList<T>.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.Collections.Generic.LinkedList<T> is empty.
        public void RemoveFirst()
        {
            this.First = this.First.Next;
            this.Count--;
        }
    }
}
