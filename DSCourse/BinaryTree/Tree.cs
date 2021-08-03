using System;
using System.CodeDom;

namespace DSCourse.BinaryTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            this.Root = null;
        }

        public Node AddNode(Node current, int value)
        {
            if (current == null) {
                return new Node(value);
            }

            if (value > current.Value) {

                current.Right = this.AddNode(current.Right, value);
            }
            else {
                current.Left = this.AddNode(current.Left, value);
            }

            return current;
        }

        public void PrintNode(Node current)
        {
            if (current == null) 
                return;
            PrintNode(current.Left);
            Console.WriteLine(current.Value);
            PrintNode(current.Right);
        }
    }
}