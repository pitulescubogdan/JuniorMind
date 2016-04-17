using System;
using System.Collections;
using System.Collections.Generic;


namespace LinkedList.Test
{
    public class LinkedLists<T> : ICollection<T>,IEnumerable<T>
    {
        private Node head;
        private int count;
        public T this[int index]
        {
            get
            {
                return this.Get(index);
            }
        }
        public LinkedLists()
        {
            this.head = new Node(default(T));
            head.Next = head;
            head.Previous = head;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }

        }
        public int Count
        {
            get { return count; }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T obj)
        {
            this.AddLast(obj);
        }
        public void AddLast(T obj)
        {
            Node last = head.Previous;
            Node newNode = new Node(obj);
            newNode.Next = head;
            newNode.Previous = head.Previous;

            head.Previous = newNode;
            last.Next = newNode;

            count++;
        }
        public void AddFirst(T obj)
        {
            Node first = head.Next;
            Node newNode = new Node(obj);
            newNode.Next = head.Next;
            newNode.Previous = head;

            head.Next = newNode;
            first.Previous = newNode;
            count++;
        }
        public void RemoveAt(int index)
        {
            Node toRemove = head.Next;
            for (int i = 0; i < index; i++)
            {
                toRemove = toRemove.Next;
            }

            RemoveLink(toRemove);

            count--;
        }
        public void Remove(T obj)
        {
            Node toRemove = head.Next;
            for (int i = 0; i < count; i++)
            {
                if (toRemove.Data.Equals(obj))
                {
                    RemoveLink(toRemove);
                }
                toRemove = toRemove.Next;
            }
        }
        public void Clear()
        {
            head = null;
            count = 0;
        }
        public int IndexOf(object obj)
        {
            var index = 0;
            for (var current = head.Next; current != head; current = current.Next, index++)
            {
                if (current == null) break;
                if (current.Data.Equals(obj)) return index;
            }

            return -1;
        }
        public bool Contains(T obj)
        {
            return IndexOf(obj) >= 0;
        }
        public T Get(int index)
        {
            var current = head.Next;
            for (var i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return (T)current.Data;
        }
        private static void RemoveLink(Node toRemove)
        {
            Node left = toRemove.Previous;
            Node right = toRemove.Next;

            left.Next = right;
            right.Previous = left;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(var current = head.Next;current != head; current = current.Next)
            {
                yield return (T)current.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
