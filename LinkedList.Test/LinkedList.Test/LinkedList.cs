using System.Collections.Generic;


namespace LinkedList.Test
{
    public class LinkedLists<T> : LinkedList<T>
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
            this.head = new Node(default(T), null, null);
            head.Next = head;
            head.Previous = head;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }

        }
        public new int Count
        {
            get { return count; }
        }
        public void Add(T obj)
        {
            Node last = head.Previous;
            Node newNode = new Node(obj, head, head.Previous);

            head.Previous = newNode;
            last.Next = newNode;

            count++;
        }
        public void AddPrevious(T obj)
        {
            Node first = head.Next;
            Node newNode = new Node(obj, head.Next, head);
            head.Next = newNode;
            first.Previous = newNode;
            count++;

        }

        public void Remove(int index)
        {
            Node current = this.head;

            current.Next.Data = default(T);
            current.Next = current.Next.Next;

            count--;
        }
        public new void Clear()
        {
            head = null;
            count = 0;
        }
        public int IndexOf(T obj)
        {
            int index = 0;
            Node current = head.Next;
            while (current != head)
            {
                if (current.Data.Equals(obj))
                    return index;
                current = current.Next;
                index++;
            }

            return -1;
        }
        public new bool Contains(T obj)
        {
            return IndexOf(obj) >= 0;
        }
        public T Get(int index)
        {
            int j = 0;
            Node current = head.Next;

            while (current != null)
            {
                if (index == j) return (T)current.Data;
                current = current.Next;
                j++;
            }
            return default(T);
        }
    }
}
