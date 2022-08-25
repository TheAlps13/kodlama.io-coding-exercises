using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;

        public int Count { get; private set; }

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            Count++;

            Array.Resize(ref _keys, Count);
            Array.Resize(ref _values, Count);

            _keys[Count - 1] = key;
            _values[Count - 1] = value;
        }

        public TValue this[TKey key]
        {
            get
            {
                int index;
                if ((index = Array.IndexOf(_keys, key)) != -1)
                {
                     TValue value = _values[index];
                return value;
                }

                throw new Exception("Key not found");
            }
        }

        public void List()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Key: {_keys[i]}" +
                    $"\nValue: {_values[i]}" +
                    "\n***************");
            }
        }
    }
}
