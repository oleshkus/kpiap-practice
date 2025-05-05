namespace task1;

public class MyDictionary<TKey, TValue>
{
    private (TKey Key, TValue Value)[] _items = new (TKey Key, TValue Value)[0];
    public TValue this[TKey key]
    {
        get
        {
            foreach (var item in _items)
            {
                if (item.Key != null && item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default;
        }
        set
        {
            for (int i = 0; i < _items.Length; i++)
            {
                var key1 = _items[i].Key;
                if (key1 != null && key1.Equals(key))
                {
                    _items[i] = (key, value);
                    return;
                }
            }
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = (key, value);
        }
    }
    
    public int Count => _items.Length;
    
    public void Add(TKey key, TValue value) => this[key] = value;
    
    public void Remove(TKey key)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            var key1 = _items[i].Key;
            if (key1 != null && key1.Equals(key))
            {
                Array.Copy(_items, i + 1, _items, i, _items.Length - i - 1);
                Array.Resize(ref _items, _items.Length - 1);
                return;
            }
        }
    }
    
    public void Clear() => Array.Resize(ref _items, 0);
    
    public bool ContainsKey(TKey key)
    {
        foreach (var item in _items)
        {
            if (item.Key != null && item.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }
}