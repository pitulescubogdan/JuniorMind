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
        private int size;

        public LinkedLists()
        {
            this.head = null;
            this.size = 0;
        }

        public bool Empty
        {
            get { return this.size == 0; }

        }
        public new int Count
        {
            get { return this.size; }
        }

    }
}
