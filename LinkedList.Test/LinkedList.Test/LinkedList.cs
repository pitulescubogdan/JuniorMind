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
            this.head = null;
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
        public void Add(int index, T obj)
        {
            if (index > count) index = count - 1;

            Node current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Node(obj, this.head);
            }
            else
            {
                current = LinkElements(index, current);
                current.Next = new Node(obj, current.Next);
            }
            count++;
        }
        public void Add(T obj)
        {
            this.Add(count, obj);
        }
        public void Remove(int index)
        {
            if (index >= count) index = count - 1;

            Node current = this.head;

            if (index == 0)
            {
                current.Data = default(T);
                this.head = current.Next;
            }
            else
            {
                LinkElements(index, current);

                current.Next.Data = default(T);
                current.Next = current.Next.Next;
            }
            count--;
        }
        public new void Clear()
        {
            head = null;
            count = 0;
        }
        public int IndexOf(T obj)
        {
            Node current = this.head;
            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(obj)) return i;

                current = current.Next;
            }
            return -1;
        }
        public new bool Contains(T obj)
        {
            return IndexOf(obj) >= 0;
        }
        public T Get(int index)
        {
            if (Empty) return default(T);
            if (index >= count) index = count - 1;

            Node current = this.head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return (T)current.Data;
        }
        private static Node LinkElements(int index, Node current)
        {
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            return current;
        }
    }
}
