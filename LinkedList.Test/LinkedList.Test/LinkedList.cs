using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Test
{
    public class LinkedLists<T> : LinkedList<T>
    {
        private Node head;
        private int count;

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
            get { return this.count; }
        }

        public void Add(int index,T obj)
        {
            if (index > count) index = count;

            Node current = this.head;

            if(this.Empty || index == 0)
            {
                this.head = new Node(obj, this.head);
            }
            else
            {
                for(int i = 0;i<index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(obj, current.Next);
            }
            count++;
        }
        public void Add(T obj)
        {
            this.Add(count, obj);
        }

    }
}
