using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCourse.SentinelList
{
    public class SentinelList
    {
        Node _head = new Node(0);
        Node _tail = new Node(0);

        public SentinelList()
        {
            // Empty List starts with head and tail pointing to each other 
            this._head.Next = this._tail;
            this._tail.Previous = this._head;
        }

        public void AddToBack(int a)
        {
            var newNode = new Node(a);
            newNode.Next = this._tail;
            newNode.Previous = this._tail.Previous;
            this._tail.Previous.Next = newNode;
            this._tail.Previous = newNode;
        }

        public void Remove(int value)
        {
            // Start from head and move till tail
            for (Node current = this._head.Next; current != this._tail; current = current.Next)
            {
                if (current == null)
                {
                    Console.WriteLine("Node not found.");
                    return;
                }
                // The loop starts from the head next and goes till the tail hence no need to check the conditions.      
                if (current.Value == value)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                }
            }
        }

        public void InsertBefore(int valueToSearch, params int[] list)
        {
            for (Node current = this._head.Next; current != this._tail; current = current.Next)
            {
                if (current.Value == valueToSearch)
                {
                    foreach (var item in list)
                    {
                        var newNode = new Node(item);
                        newNode.Next = current;
                        newNode.Previous = current.Previous;
                        current.Previous.Next = newNode;
                        current = newNode;
                    }
                }
            }
        }

        public void PrintForward()
        {
            for (Node current = this._head.Next; current != this._tail; current = current.Next)
            {
                Console.WriteLine(current.Value);
            }
        }

    }
}
