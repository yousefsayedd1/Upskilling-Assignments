namespace Day3._2
{
    public class Cashing<TKey, TValue> where TKey : IComparable
    {
        const int _capacity = 5;
        TKey[] _keys = new TKey[_capacity];
        TValue[] _values = new TValue[_capacity];
        int _index = -1;
        private void ShiftKeys(int start, int end)
        {
            if (start < 0 || end >= _capacity) throw new ArgumentOutOfRangeException();
            for (int i = start; i < end; i++)
            {
                _keys[i] = _keys[i + 1];
                _values[i] = _values[i + 1];
            }
            _keys[end] =  default(TKey);
            _values[end] = default(TValue);
        }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(_keys[i] , key))
                {
                    _values[i] = value;
                    return;
                }
            }
            if (_index+1 == _keys.Length)
            {
                ShiftKeys(0, _capacity - 1);
            }
            else _index++;

            _keys[_index] = key;
            _values[_index] = value;
        }
        public TValue Retrieve(TKey key) 
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(_keys[i],  key))
                {
                    TKey TkeyTemp = _keys[i];
                    TValue TvalueTemp = _values[i];
                    ShiftKeys(i, _capacity - 1);
                    _keys[_index] = TkeyTemp;
                    _values[_index] = TvalueTemp;
                    return _values[i];
                }
            }
            return default(TValue);
        }
        public void Remove(TKey key)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(_keys[i], key))
                {
                    ShiftKeys(i, _capacity - 1);
                    _index--;
                }
            }
        }
    }
}
