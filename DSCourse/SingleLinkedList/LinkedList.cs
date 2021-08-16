using System;
using System.Security.Cryptography.X509Certificates;

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

        public void AddToEnd(params int[] values)
        {
            foreach (var value in values)
            {
                var reff = new Node(value);
                if (_head == null)
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
            
        }

        public void ReverseLinkedList()
        {
            if (this._head == null)
            {
                throw new Exception("Empty Linked List");
            }
            
            Node previous = null;
            Node currentNode = this._head;
            Node nextNode = null;

            while (currentNode != null )
            {
                nextNode = currentNode.Next;
                currentNode.Next = previous;
                previous = currentNode;
                currentNode = nextNode;
            }

            this._head = previous;

        }

        public void Remove(int valueToRemove)
        {
            var back = _head;
            for (Node current = _head; current != null; current = current.Next)
            {
                if (current.Value == valueToRemove)
                {
                    // If the node is head then save the head to the next node 
                    if (current == _head)
                    {
                        _head = _head.Next;
                        return;
                    }

                    // If the node is tail then move the tail to previous node which is in back here. 
                    if (current == _tail)
                    {
                        _tail = back;
                        _tail.Next = null;
                        return;
                    }

                    // If the node is in the middle then use the back next to current node's next so that the current can be dropped. 
                    back.Next = current.Next;
                }

                back = current;
            }
        }

        public void PrintBackward()
        {
            Recursive(this._head);

            Node Recursive(Node node)
            {
                if (node == null)
                    return null;
                var result = Recursive(node.Next);

                Console.WriteLine($"{result.Value}");
                return result;
            }

        }

        public void PrintForward()
        {
            for (Node current = _head; current != null; current = current.Next )
            {
                Console.WriteLine( $"{current.Value} "  );
            }
        }
    }


}
