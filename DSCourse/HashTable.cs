using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace DSCourse
{
    public class Entry
    {
        public Entry Next { get; set; }
        public int Value { get; set; }
        
        public Entry(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    public class HashTable
    {
        private int _size = 0;
        private Entry[] _table = null;

        public HashTable(int size = 10)
        {
            this._size = size;
            this._table = new Entry[size] ;
        }

        public int Hash(int input)
        {
            return input % _size;
        }

        public void PutItem(int input)
        {
            var index = this.Hash(input);
            var newNode = new Entry(input) {Next = null};

            // If there's already a value existing 
            if (_table[index] != null)
            {
                // Make the new node as the head
                newNode.Next = _table[index];
            }
            _table[index] = newNode;
        }

        public int? GetItem(int input)
        {
            var index = this.Hash(input);
            for (var  current = this._table[index]; current != null; current= current.Next)
            {
                if (current.Value == input)
                {
                    return current.Value;
                }
            }

            return null;
        }

        public void RemoveItem(int input)
        {
            var index = this.Hash(input);

            var back = this._table[index];

            for (var current = this._table[index]; current != null ; current = current.Next)
            {
                if (current.Value == input)
                {
                    if (current == _table[index])
                    {
                        _table[index] = current.Next;
                        return;
                    }

                    back.Next = current.Next;

                }

                back = current;
            }

            this._table[index] = null;
        }


        public void Print()
        {
            for (int index = 0; index < this._table.Length; index++)
            {
                var log = $"{index}: [";
                for (var current = this._table[index]; current != null; current = current.Next )
                {
                    log += current.Value + ", ";
                }

                log += "]";
                Console.WriteLine($"{log}");
            }
        }

    }
}