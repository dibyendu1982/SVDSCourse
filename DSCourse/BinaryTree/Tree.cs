using System;
using System.CodeDom;
using System.Linq;
using System.Runtime.InteropServices;

namespace DSCourse.BinaryTree
{
    public class Tree
    {
        private Node _root;

        public Tree()
        {
            _root = null;
        }

        public void AddNodes(params int[] values)
        {
            foreach (var value in values)
            {
                _root = this.AddNodeWithRecursion(_root, value);
            }
        }

        private Node AddNodeWithRecursion(Node current, int value)
        {
            if (current == null) {
                return new Node(value);
            }

            if (value > current.Value) {

                current.Right = this.AddNodeWithRecursion(current.Right, value);
            }
            else {
                current.Left = this.AddNodeWithRecursion(current.Left, value);
            }

            return current;
        }

        public void Remove(int value)
        {
            this._root = RemoveNode(this._root);

            // Local Function
            Node RemoveNode(Node current)
            {
                if (current == null)
                    return null;

                if (value > current.Value)
                {
                    current.Right = RemoveNode(current.Right); // Hand it to the grand - father 
                }
                else if (value < current.Value)
                {
                    current.Left = RemoveNode(current.Left); // Hand it to the grand - father 
                }
                else
                {
                    // found the element 
                    if (current.Left == null && current.Right == null)
                    {
                        Console.WriteLine("No child hence return null");
                        return null;
                    }

                    // Only has a right child 
                    if (current.Left == null && current.Right != null)
                    {
                        Console.WriteLine($"Only has a right child node - {current.Value} --> {current.Right.Value}");
                        return current.Right;
                    }

                    // only has left child
                    if (current.Right == null && current.Left != null)
                    {
                        Console.WriteLine($"Only has a left child node - {current.Value} --> {current.Left.Value}");
                        return current.Left;
                    }
                }

                return current;
            }
        }

        public void PrintTreeInOrder()
        {
            PrintInOrder(_root);

            // Local Function
            void PrintInOrder(Node current)
            {
                if (current == null)
                    return;
                PrintInOrder(current.Left);
                Console.WriteLine(current.Value);
                PrintInOrder(current.Right);
            }
        }

        public void PrintTreePreOrder()
        {
            PrintPreOrder(_root);
            // Local Function
            void PrintPreOrder(Node current)
            {
                if (current == null)
                    return;

                Console.WriteLine(current.Value);
                PrintPreOrder(current.Right);
                PrintPreOrder(current.Left);
            }
        }

        public void PrintTreePostOrder()
        {
            PrintPostOrder(_root);
            // Local Function
            void PrintPostOrder(Node current)
            {
                if (current == null)
                    return;
                PrintPostOrder(current.Left);
                PrintPostOrder(current.Right);
                Console.WriteLine(current.Value);
            }
        }
    }
}