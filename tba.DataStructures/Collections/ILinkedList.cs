using System;
namespace tba.DataStructures.Collections
{
    public interface ILinkedList<T>
    {
        LinkedListNode<T> AddFirst(T value);
        int Count { get; }
        LinkedListNode<T> First { get; }
        void RemoveFirst();
    }
}
