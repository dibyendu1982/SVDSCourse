using System;
using System.Runtime.CompilerServices;

namespace DSCourse
{
    public class LinkedNode
    {
        public LinkedNode Next { get; set; }
        public int Value { get; set; }

        public LinkedNode(int value)
        {
            this.Value = value;
        }
    }

    public class StackAsLinkedList
    {
        private LinkedNode _head = null;

        public StackAsLinkedList()
        {
            this._head = null;
        }

        public void Push(params int[] values)
        {
            foreach (var value in values)
            {
                // In a stack always add to the head. 
                var newNode = new LinkedNode(value);

                // Always insert at the head since its a stack
                newNode.Next = this._head;
                this._head = newNode;
            }
            
        }

        public int Pop()
        {
            // In a  stack always remove from the head of the linked list 
            if (_head == null)
            {
                throw new Exception("Stack UnderflowException");
            }

            var valueToBeRemoved = this._head.Value;
            this._head = this._head.Next;
            return valueToBeRemoved;
        }

        public void Print()
        {
            for (var currentNode = this._head; currentNode != null; currentNode = currentNode.Next)
            {
                Console.WriteLine($"{currentNode.Value}");
            }
        }

    }
}