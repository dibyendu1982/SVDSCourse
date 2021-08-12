using System;
using System.CodeDom;

namespace DSCourse
{
    public class QueueAsArray
    {
        public readonly int _size = 0;
        public int[] _array = null;
        private int _currentPosition = -1;
        private int _frontPosition = -1;

        public QueueAsArray(int size)
        {
            this._array = new int[size];
        }

        public void Enqueue(params int[] values)
        {
            if (_currentPosition > this._array.Length)
            {
                throw new Exception("Queue is full");
            }
            foreach (var value in values)
            {
               this._array[_currentPosition + 1] = value;
               _currentPosition += 1;
            }
        }

        public int Dequeue()
        {
            if (this._frontPosition > this._array.Length)
            {
                throw new Exception("Queue is empty");
            }

            var elementToDeque = this._array[_frontPosition + 1];
            _frontPosition += 1;
            return elementToDeque;
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