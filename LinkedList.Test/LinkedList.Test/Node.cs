namespace LinkedList.Test
{
    public class Node
    {
        private object data;
        private Node next;
        private Node previous;

        public Node(object data, Node next, Node previous)
        {
            this.data = data;
            this.next = next;
            this.previous = previous;
            
        }
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Node Previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }

    }
}
