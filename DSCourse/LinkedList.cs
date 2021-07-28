using System;

namespace DSCourse
{
    public class LinkedList
    {
        Node _head = null;
        Node _tail = null;

        public LinkedList()
        {
            this._head = null;
            this._tail = null;

        }

        public void AddToEnd(int a)
        {

            var reff = new Node(a);
            if (_head ==  null)
            {
                _head = reff;
                _tail = reff;
            }
            else
            {
                this._tail.Next = reff;
                this._tail = reff;
            }
        }

        public void AddToFront(int a)
        {

            var reff = new Node(a);
            if (_head == null)
            {
                _tail = reff;
            }
            else
            {
                reff.Next = _head;
                this._head = reff;
                
            }
        }

        public void PrintLinkedList()
        {
            for (Node current = _head; current != null; current = current.Next )
            {
                Console.WriteLine( $"{current.Value} "  );
            }
        }
    }


}
