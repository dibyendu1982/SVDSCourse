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
            DoublyLinkedListOperations();
            //SentinelListOperations();
            //CircularSentinelOperations();
            //Factorial();
            //TreeOperations();
            //HashTableOperations();
            //MapUsingKeyValueOperations();
            //StackAsArrayOperations();
            //StackAsLinkedListOperations();
            //QueueAsArrayOperations();
            //QueueAsDoubleLinkedListOperations();

        }

        private static void QueueAsDoubleLinkedListOperations()
        {
            var queueAsLinkedList = new QueueAsDoubleLinkedList();
            queueAsLinkedList.Enqueue(6,7,8,9,10);
            Console.WriteLine("Here's what array looked like: ");
            queueAsLinkedList.Print();
            Console.WriteLine($" Node Dequeued: {queueAsLinkedList.Dequeue()} ");
            Console.WriteLine($" Node Dequeued: {queueAsLinkedList.Dequeue()} ");
            queueAsLinkedList.Enqueue(11, 12, 13);
            queueAsLinkedList.Print();
        }

        private static void QueueAsArrayOperations()
        {
            var queueAsArray = new QueueAsArray(10);
            queueAsArray.Enqueue(1, 2, 3, 4, 5);
            queueAsArray.Dequeue();
            Console.WriteLine(queueAsArray.Dequeue());
            queueAsArray.Print();
        }

        private static void StackAsLinkedListOperations()
        {
            var stackAsLinkedList = new StackAsLinkedList();
            stackAsLinkedList.Push(1, 2 , 3, 4);
            stackAsLinkedList.Print();
            Console.WriteLine("After couple of pops");
            stackAsLinkedList.Pop();
            stackAsLinkedList.Pop();
            stackAsLinkedList.Print();
            Console.ReadLine();

        }

        private static void StackAsArrayOperations()
        {
            var stackAsArray = new StackAsArray(10);
            stackAsArray.Push(10);
            stackAsArray.Push(9);
            stackAsArray.Push(8);
            stackAsArray.Push(7);
            stackAsArray.Push(6);
            stackAsArray.Push(5);

            stackAsArray.Pop();
            stackAsArray.Pop();

            stackAsArray.Seek();

            stackAsArray.Print();
        }

        private static void MapUsingKeyValueOperations()
        {
            var mapUsingKeyValue = new MapUsingKeyValue(10);
            mapUsingKeyValue.PutItem(823, "test1");
            mapUsingKeyValue.PutItem(821, "test2");
            mapUsingKeyValue.PutItem(822, "test3");
            mapUsingKeyValue.PutItem(820, "test4");
            mapUsingKeyValue.PutItem(420, "test5");
            mapUsingKeyValue.Print();
        }

        private static void HashTableOperations()
        {
            var hashTable = new HashTable();

            hashTable.PutItem(10);
            hashTable.PutItem(20);
            hashTable.PutItem(30);
            hashTable.PutItem(9);
            hashTable.PutItem(8);
            hashTable.PutItem(7);

            hashTable.RemoveItem(7);

            hashTable.Print();

            Console.ReadLine();
        }

        private static void Factorial()
        {
            var factorial = new Recursion.FactorialImplementation();

            Console.WriteLine(factorial.RecursiveFactorial(5));
            Console.WriteLine(factorial.NonRecursiveFactorial(5));
        }

        private static void CircularSentinelOperations()
        {
            var circularSentinel = new CircularSentinelList();
            circularSentinel.AddToFront(10, 11, 12, 13);
            circularSentinel.PrintCircularSentinel();
        }

        private static void TreeOperations()
        {
            var tree = new Tree();
            tree.AddNodes(5, 7, 1, 9, 8, 2, 10);
          
            Console.WriteLine("InOrder");
            tree.PrintTreeInOrder();
            Console.WriteLine("tree Structure");
            tree.PrintTreeStructure();

            tree.Remove(7);

            Console.WriteLine("tree Structure");
            tree.PrintTreeStructure();
            //Console.WriteLine("PreOrder");
            //tree.PrintTreePreOrder();
            //Console.WriteLine("PostOrder");
            //tree.PrintTreePostOrder();
            //Console.WriteLine("PreOrder");


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
            linkedList.AddToEnd(5, 6, 9, 1);
            linkedList.AddToFront(10);
            linkedList.AddToFront(11);
            linkedList.ReverseLinkedList();
            linkedList.PrintForward();

            //linkedList.PrintBackward();
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

            doubleLinkedList.ReverseDoublyLinkedList();

            //doubleLinkedList.SkipAndDeleteNodes(1, 12, 3);

            Console.WriteLine("Printing in forward  after operation.");
            doubleLinkedList.PrintForward();
        }
    }


}
