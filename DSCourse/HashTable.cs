using System;
using System.Collections.Generic;

namespace DSCourse
{
    public class HashTable
    {
        private int _size = 0;
        private int?[] _table = null;

        public HashTable(int size = 10)
        {
            this._size = size;
            this._table = new int?[size];
        }

        public int Hash(int input)
        {
            return input % _size;
        }

        public void PutItem(int input)
        {
            var index = this.Hash(input);
            this._table[index] = input;
        }

        public int? GetItem(int input)
        {
            var index = this.Hash(input);
            return this._table[index];
        }

        public void RemoveItem(int input)
        {
            var index = this.Hash(input);
            this._table[index] = null;
        }

        public void Print()
        {
            for (int index = 0; index < this._table.Length; index++)
            {
                Console.WriteLine($"{index}: {_table[index]}");
            }
        }

    }
}