﻿using System;

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
        public void AddToFront(int value)
        {
            var newNode = new Node(value);
            if (_head == null)
            {
                this._head = newNode;
                this._tail = newNode;
            }
            else
            {
                newNode.Next = this._head;
                this._head.Previous = newNode;
                this._head = newNode;
            }
        }

        public void InsertNodeAfter(int valueToSearch, int valueToInsert)
        {
            for (Node current = this._head; current != null; current = current.Next)
            {
                //! If the value is not found 
                if (current == null)
                {
                    Console.WriteLine("Node Not found");
                    return;
                }

                // This means the value is somewhere in the middle.
                if (current.Value == valueToSearch)
                {
                    // if the value is found at the end then add to back

                    if (current == this._tail)
                    {
                        AddToBack(valueToInsert);
                    }

                    var nodeToInsert = new Node(valueToInsert);
                    // Set the previous node to current node after which the value needs to be inserted
                    nodeToInsert.Previous = current;  //Left hand on the left node
                                                      // Next of the NodeToInsert should be current nodes next 
                    nodeToInsert.Next = current.Next; // Right hand on the right node
                    current.Next.Previous = nodeToInsert; // Setting the previous after the insert and pointing it to the new node. 
                    current.Next = nodeToInsert;
                }
            }
        }


        public void InsertNodeBefore(int valueToSearch, int valueToInsert)
        {
            for (Node current = this._head; current != null; current = current.Next)
            {
                //! If the current is null it means the loop has reached the end of the tail because this._tail.next = null;
                // This means that the value is not present in the list. 
                if (current == null)
                {
                    Console.WriteLine("Node Not found");
                    return;
                }

                if (current.Value == valueToSearch)
                {
                    // if the value is found at the end then add to back
                    if (current == this._head)
                    {
                        AddToFront(valueToInsert);
                        return;
                    }

                    var nodeToInsert = new Node(valueToInsert);
                    nodeToInsert.Next = current;
                    nodeToInsert.Previous = current.Previous;
                    current.Previous.Next = nodeToInsert;
                    current.Previous = nodeToInsert;
                }
            }
        }

        public void DeleteNode(int valueToDelete)
        {
            for (Node current = this._head; current != null; current = current.Next)
            {
                if (valueToDelete == current.Value)
                {
                    // Just 1 node which is head and tail both
                    if (this._head == this._tail)
                    {
                        this._head = null;
                        this._tail = null;
                        return;
                    }

                    // Removing Head, move the head to the next node, since head does not have a previous node set it to null
                    if (current == this._head)
                    {
                        this._head = this._head.Next;
                        this._head.Previous = null;
                        return;
                    }

                    // Removing Tail, move the tail to the previous node and then set the tails next to null;
                    if (current == this._tail)
                    {
                        this._tail = this._tail.Previous;
                        this._tail.Next = null;
                        return;
                    }

                    // Removing the node from somewhere in middle
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                }
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
