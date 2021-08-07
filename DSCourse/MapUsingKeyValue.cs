using System;

namespace DSCourse
{
    public class MapEntry
    {
        public MapEntry Next { get; set; }

        public int Key { get; set; }
        public string Value { get; set; }

        public MapEntry(int key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.Next = null;
        }
    }

    public class MapUsingKeyValue
    {
        private int _size = 0;

        private MapEntry[] _table = null;

        public MapUsingKeyValue(int size = 10)
        {
            this._size = size;
            this._table = new MapEntry[size];
        }

        public int Hash(int key)
        {
            return key % 10;
        }

        public void PutItem(int key, string value)
        {
            // Get the offset and Find the bucket 
            var offset = this.Hash(key);
            if (this._table[offset] == null)
            {
                this._table[offset] = new MapEntry(key, value);
            }
            else
            {
                var newNode = new MapEntry(key, value) {Next = _table[offset].Next};
                _table[offset].Next = newNode;
            }
        }

        public void GetItem(int key)
        {
            // Get the offset and Find the bucket 
            var offset = this.Hash(key);
            var bucket = this._table[offset];

            if (bucket == null)
            {
                Console.WriteLine("Node Not found");
                return;
            }
            else
            {
                for (var current = this._table[offset]; current != null ; current.Next = current)
                {
                    if (current.Key == key)
                    {
                        Console.WriteLine($"{current.Key}:{current.Value}");
                    }
                }
            }
        }

        public void RemoveItem(int key)
        {
            var offset = this.Hash(key);
            var back = this._table[offset];

            for (var current = this._table[offset]; current != null; current.Next = current)
            {
                if (current.Key == key)
                {
                    // if the node is the first node 
                    if (current == this._table[offset])
                    {
                        this._table[offset] = this._table[offset].Next;
                    }

                    back.Next = current.Next;
                }

                back = current;
            }

        }

        public void Print()
        {
            for (int index = 0; index < this._table.Length; index++)
            {
                var log = $"{index}: [";
                for (var current = this._table[index]; current != null; current = current.Next)
                {
                    log += "{" + current.Key + ":" + current.Value + "}, ";
                }

                log += "]";
                Console.WriteLine($"{log}");
            }
        }

    }
}