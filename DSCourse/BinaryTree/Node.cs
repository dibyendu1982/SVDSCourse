using System.Data;

namespace DSCourse.BinaryTree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.Left = this.Right = null;
        }
    }
}