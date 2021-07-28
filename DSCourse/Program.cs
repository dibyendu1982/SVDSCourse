using System;

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

            var linkedList = new LinkedList();
            linkedList.AddToEnd(5);
            linkedList.AddToEnd(6);
            linkedList.AddToEnd(9);
            linkedList.AddToEnd(1);
            linkedList.AddToFront(10);
            linkedList.AddToFront(11);


            linkedList.PrintLinkedList();

            Console.ReadLine();
        }
    }


}
