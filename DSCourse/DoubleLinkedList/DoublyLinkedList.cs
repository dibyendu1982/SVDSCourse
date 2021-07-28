using System;

namespace DSCourse.DoubleLinkedList
{
    public class DoublyLinkedList
    {
        Node _head = null;
        Node _tail = null;

        public DoublyLinkedList()
        {
            this._head = null;
            this._tail = null;

        }

        public void AddToBack (int value)
        {
            var newNode = new Node(value);

            if (_head == null)
            {
                this._head = newNode;
                this._tail = newNode;
            }
            else
            {
                this._tail.Next = newNode;
                newNode.Previous = this._tail;
                this._tail = newNode;
            }
        }


        public void PrintBackward()
        {
            for (Node current = this._tail; current!= null; current = current.Previous)
            {
                Console.WriteLine(current.Value);
            }
        }

        public void PrintForward()
        {
            for (Node current = this._head; current != null; current = current.Next)
            {
                Console.WriteLine(current.Value);
            }
        }
    }
}
