using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private T[] _items;
        public int Count { get; private set; }

        public MyList()
        {
            _items = new T[0];
        }
        public void Add(T item)
        {
            Count++;
            Array.Resize(ref _items, Count);
            _items[Count - 1] = item;
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

    }


}
