using System;
using System.CodeDom;
using System.Linq;
using System.Runtime.InteropServices;

namespace DSCourse.BinaryTree
{
    public class Tree
    {
        private Node _root;
        private static int _level = 0;
        private const string _SPACES = "    ";

        public Tree()
        {
            _root = null;
        }

        public void AddNodes(params int[] values)
        {
            foreach (var value in values)
            {
                _root = AddNodeWithRecursion(_root, value);
            }

            Node AddNodeWithRecursion(Node current, int value)
            {
                if (current == null)
                {
                    return new Node(value);
                }

                if (value > current.Value)
                {

                    current.Right = AddNodeWithRecursion(current.Right, value);
                }
                else
                {
                    current.Left = AddNodeWithRecursion(current.Left, value);
                }

                return current;
            }
        }

        

        public void Remove(int value)
        {
            this._root = RemoveNode(this._root); // This is Data Abstraction 

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
                    // MIL GAYI!!! Found the value
                    // found the element 

                    // ~ Case 1: node has no children 
                    if (current.Left == null && current.Right == null)
                    {
                        Console.WriteLine("No child hence return null");
                        return null;
                    }

                    // ~ Case 2 & 3: Either left or right chile is alive 
                    if (current.Left == null || current.Right == null)
                    {
                        return current.Left ?? current.Right;
                    }

                    // ~ Case 4: Node has both the child, then deletion needs to happen with the Successor. 
                    // * Find successor (Left most node of the Right subtree) or predecessor (Right most node of the left subtree)
                    var successor = current.Right; //starting point for finding the successor 

                    while (successor.Left != null)
                        successor = successor.Left;

                    //Successor found 
                    Console.WriteLine($"Case 4: {current.Value}");
                    value = successor.Value;
                    current.Right = RemoveNode(current.Right);
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

        public void PrintTreeStructure()
        {
            string treeStructure = string.Empty;
            PrintTreeRecursive(this._root);

            void PrintTreeRecursive(Node current)
            {
                // There's nothing to print 
                if (current == null)
                    return;

                _level++;
                PrintTreeRecursive(current.Right);
                var indent = string.Empty;

                for (int count = 1; count < _level; indent += _SPACES, count++) ;
                treeStructure += $"{indent}{current.Value}\n";

                PrintTreeRecursive(current.Left);
                _level--;
            }

            Console.WriteLine($"{treeStructure}");
        }
    }
}