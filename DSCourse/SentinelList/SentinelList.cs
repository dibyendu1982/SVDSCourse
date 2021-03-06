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

        public void Remove(int valueToDelete)
        {
            // Start from head and move till tail
            for (var current = this._head.Next; current != this._tail; current = current.Next)
            {
                if (current == null)
                {
                    Console.WriteLine("Node not found.");
                    return;
                }
                // Don't do anything if the value is not matching just move on to the next node.
                if (current.Value != valueToDelete) 
                    continue;

                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
            }
        }

        public void InsertNodesBefore(int valueToSearch, params int[] list)
        {
            for (var current = this._head.Next; current != this._tail; current = current.Next)
            {
                if (current.Value != valueToSearch) 
                    continue;
                foreach (var item in list)
                {
                    InsertNode(item, current, true);
                }
            }
        }

        public void InsertNodesAfter(int valueToSearch, params int[] list)
        {
            for (var current = this._head.Next; current != this._tail; current = current.Next)
            {
                // Continue with the loop if value is not matched.
                if (current.Value != valueToSearch)
                    continue;
                foreach (var item in list)
                {
                    InsertNode(item, current);
                }
            }
        }

        private static void InsertNode(int item, Node current, bool before = false)
        {
            var newNode = new Node(item);

            // Left Hand and Right Hand
            if (before)
            {
                newNode.Previous = current.Previous;
                newNode.Next = current;
            }
            else
            {
                newNode.Previous = current;
                newNode.Next = current.Next;
            }
            
            PullMeUpOnWall(newNode);
        }

        private static void PullMeUpOnWall(Node newNode)
        {
            newNode.Previous.Next = newNode.Next.Previous = newNode;
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
