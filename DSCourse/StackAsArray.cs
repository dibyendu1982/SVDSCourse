using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace DSCourse
{
    public class StackAsArray
    {
        private readonly int _size = 0;
        private int[] _array = null;
        private int _topPosition = -1;

        public StackAsArray(int size)
        {
            this._size = size;
            this._array = new int[size];
        }
        public bool IsEmpty => (_topPosition == -1);
        public bool IsFull => (_topPosition > this._array.Length - 1);

        public void Push(int value)
        {
            if (IsFull)
            {
                throw new StackOverflowException("Entering the entries more than allocated");
            }
            _array[_topPosition + 1] = value;
            _topPosition++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack Under flow Exception");
            }

            if (IsFull )
            {
                throw new StackOverflowException("Entering the entries more than allocated");
            }

            var poppedElement = _array[_topPosition];
            _array[_topPosition] = 0;
            _topPosition--;
            Console.WriteLine($"{poppedElement}");
            return poppedElement;
        }

        public int Seek()
        {
            if(IsEmpty)
                throw new Exception("Stack Under flow Exception");

            return _array[_topPosition];
        }

        public void Print()
        {
            for (int i = 0; i < this._array.Length; i++)
            {
                Console.WriteLine($"{i}:{this._array[i]}");
            }
        }

    }
}