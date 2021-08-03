using System;
using System.Runtime.InteropServices;
using DSCourse.BinaryTree;
using DSCourse.DoubleLinkedList;
using DSCourse.SentinelList;

namespace DSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListOperations();
            //DoublyLinkedListOperations();
            //SentinelListOperations();

            var tree = new Tree();
            tree.Root = tree.AddNode(null, 5);
            tree.Root = tree.AddNode(tree.Root, 7);
            tree.Root = tree.AddNode(null, 1);
            tree.Root = tree.AddNode(tree.Root, 10);

            tree.PrintNode(tree.Root);
            Console.ReadLine();
        }

        private static void SentinelListOperations()
        {
            var sentinelList = new DSCourse.SentinelList.SentinelList();

            sentinelList.AddToBack(5);
            sentinelList.AddToBack(7);
            sentinelList.AddToBack(1);
            sentinelList.AddToBack(9);

            sentinelList.PrintForward();

            sentinelList.InsertNodesBefore(9, 10, 12, 13);
            sentinelList.InsertNodesAfter(13, 14, 15, 16);
            Console.WriteLine("Print after Insert Before:");
            sentinelList.PrintForward();
        }

        private static void LinkedListOperations()
        {
            var linkedList = new LinkedList();
            linkedList.AddToEnd(5);
            linkedList.AddToEnd(6);
            linkedList.AddToEnd(9);
            linkedList.AddToEnd(1);
            linkedList.AddToFront(10);
            linkedList.AddToFront(11);

            linkedList.Remove(9);
            linkedList.Remove(11);
            linkedList.Remove(1);

            linkedList.PrintLinkedList();
        }

        public static void DoublyLinkedListOperations()
        {
            var doubleLinkedList = new DoublyLinkedList();

            doubleLinkedList.AddToBack(11);
            doubleLinkedList.AddToBack(12);
            doubleLinkedList.AddToBack(15);
            doubleLinkedList.AddToBack(67);
            doubleLinkedList.AddToBack(69);
            doubleLinkedList.AddToBack(70);
            doubleLinkedList.AddToBack(71);
            doubleLinkedList.AddToBack(72);
            doubleLinkedList.InsertNodeAfter(12, 13);
            doubleLinkedList.InsertNodeBefore(11, 27);
            doubleLinkedList.InsertNodeBefore(13, 28);
            doubleLinkedList.InsertNodeBefore(67, 29);

            Console.WriteLine("Printing in forward- Original");
            doubleLinkedList.PrintForward();

            doubleLinkedList.SkipAndDeleteNodes(1, 12, 3);

            Console.WriteLine("Printing in forward  after operation.");
            doubleLinkedList.PrintForward();
        }
    }


}
