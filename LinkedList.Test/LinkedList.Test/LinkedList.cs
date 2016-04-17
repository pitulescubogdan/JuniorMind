using System;
using System.Collections;
using System.Collections.Generic;


namespace LinkedList.Test
{
    public class LinkedLists<T> : ICollection<T>, IEnumerable<T>
    {
        private Node head;
        private int count;
        public T this[int index]
        {
            get
            {
                return this[index];
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
                return true;
            }
        }

        public void Add(T obj)
        {
            this.AddLast(obj);
        }
        public void AddLast(T obj)
        {
            var newNode = new Node(obj) { Next = head, Previous = head.Previous };
            head.Previous.Next = newNode;
            head.Previous = newNode;
            count++;
        }

        public void AddFirst(T obj)
        {
            var newNode = new Node(obj) { Next = head.Next, Previous = head };
            head.Next.Previous = newNode;
            head.Next = newNode;
            count++;
        }
        public void RemoveAt(int index)
        {
            Node toRemove;

            toRemove = Get(index);

            RemoveLink(toRemove);

            count--;
        }
        public bool Remove(T obj)
        {
            Node toRemove = head.Next;
            for (int i = 0; i < count; i++)
            {
                if (toRemove.Data.Equals(obj))
                {
                    RemoveLink(toRemove);
                    return true;
                }
                toRemove = toRemove.Next;
            }
            return false;
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
        public Node Get(int index)
        {
            var current = head.Next;
            for (var i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }
        

        public void CopyTo(T[] array, int arrayIndex)
        {
            int k = arrayIndex;
            for (var current = head.Next;current != head; current = current.Next)
            {
                array.SetValue(current.Data, k++);
            }
        }

        bool ICollection<T>.Remove(T item)
        {
            return this.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = head.Next; current != head; current = current.Next)
            {
                yield return (T)current.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private static void RemoveLink(Node toRemove)
        {
            Node left = toRemove.Previous;
            Node right = toRemove.Next;

            left.Next = right;
            right.Previous = left;
        }
    }
}
