using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DSCourse.SentinelList
{
    public class CircularSentinelList
    {
        Node singleSentinel = new Node(0);

        public CircularSentinelList()
        {
            this.singleSentinel.Next = this.singleSentinel;
            this.singleSentinel.Previous = this.singleSentinel;
        }

        public void AddToFront(params int[] items)
        {
            foreach (var item in items)
            {
                var newNode = new Node(item);
                this.AddNode(this.singleSentinel, newNode);
            }
        }

        public void AddNode(Node current, Node newNode)
        {
            newNode.Previous = current;
            newNode.Next = current.Next;
            current.Next = newNode;
            current.Next.Previous = newNode;

        }

        public void PrintCircularSentinel()
        {
            for (var current  = this.singleSentinel.Next;  current != this.singleSentinel; current= current.Next)
            {
                Console.WriteLine(current.Value);
            }
        }
    }
}
