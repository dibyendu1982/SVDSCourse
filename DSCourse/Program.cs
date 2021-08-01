using System;
using DSCourse.DoubleLinkedList;

namespace DSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = { "tata", "jaguar", "bmw", "ford" };
            //int[] intArray = { 1,8, 4, 5, 6, 7 };

            //Console.WriteLine(cars); //Prints the Type of the array
            //Console.WriteLine(intArray); // Prints the Type of the array

            //foreach (string car in cars)
            //{
            //    Console.Write("{0}  ", car);
            //}

            //foreach (int item in intArray)
            //{
            //    Console.Write("{0}  ", item);
            //}

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


            Console.WriteLine("Printing in forward");
            //doubleLinkedList.PrintForward();

            doubleLinkedList.InsertNodeAfter(12, 13);
            Console.WriteLine("Printing in forward- Original");
            doubleLinkedList.PrintForward();
            doubleLinkedList.InsertNodeBefore(11, 27);
            doubleLinkedList.InsertNodeBefore(13, 28);
            doubleLinkedList.InsertNodeBefore(67, 29);

            

            //doubleLinkedList.DeleteNode(11);

            //doubleLinkedList.DeleteNode(67);

            //doubleLinkedList.PrintBackward();

            Console.WriteLine("Printing in forward  after operation.");
            doubleLinkedList.PrintForward();

            Console.ReadLine();
        }
    }


}
