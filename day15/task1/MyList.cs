using System;

namespace task1
{
    public class MyList<T>
    {
        private T[] _items = new T[DefaultCapacity];
        private int _count = 0;
        private const int DefaultCapacity = 4;

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count++] = item;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException();
                return _items[index];
            }
        }

        public int Count => _count;
    }
}