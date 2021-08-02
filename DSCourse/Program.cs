using System;
using DSCourse.DoubleLinkedList;

namespace DSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //var linkedList = new LinkedList();
            //linkedList.AddToEnd(5);
            //linkedList.AddToEnd(6);
            //linkedList.AddToEnd(9);
            //linkedList.AddToEnd(1);
            //linkedList.AddToFront(10);
            //linkedList.AddToFront(11);

            //linkedList.Remove(9);
            //linkedList.Remove(11);
            //linkedList.Remove(1);

            //linkedList.PrintLinkedList();


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

            Console.ReadLine();
        }
    }


}
