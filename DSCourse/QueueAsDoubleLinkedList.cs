using System;
using System.Runtime.CompilerServices;

namespace DSCourse
{

    public class QueueNode
    {
        public QueueNode Prev { get; set; }

        public QueueNode Next { get; set; }

        public int Value { get; set; }

        public QueueNode(int value)
        {
            this.Prev = null;
            this.Next = null;
            this.Value = value;
        }

    }

    public class QueueAsDoubleLinkedList
    {
        private QueueNode _head = null;
        private QueueNode _tail = null;

        public QueueAsDoubleLinkedList()
        {
            this._head = null;
            this._tail = null;
        }

        public void Enqueue(params int[] values)
        {
            foreach (var value in values)
            {
                var newNode = new QueueNode(value);
                // First Node 
                if (this._head == null)
                {
                    // Set the head and tail to the new node
                    this._head = this._tail = newNode;
                }
                else
                {
                    // New node makes it to the head. 
                    newNode.Next = this._head;
                    this._head.Prev = newNode;
                    this._head = newNode;
                }
            }
        }
        
        public int Dequeue()
        {
            if (this._head == null || this._tail == null)
            {
                throw new Exception("Empty queue.");
            }
            else
            {
                var valueToBeDequeued = this._tail.Value;
                this._tail = this._tail.Prev;
                this._tail.Next = null;
                return valueToBeDequeued;
            }
        }


    }
}