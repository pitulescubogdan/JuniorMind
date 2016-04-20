using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        int[] buckets = new int[10];
        Entry[] items = new Entry[10];
        int countEntries = 1;
        int previous = 0;
        int freeIndex = 0;

        public struct Entry
        {
            public TKey TKey;
            public TValue TValue;
            public int previous;

            public Entry(TKey TKey, TValue TValue, int previous)
            {
                this.TKey = TKey;
                this.TValue = TValue;
                this.previous = previous;
            }
        }
        public TValue this[TKey key]
        {
            get
            {
                return this[key];
            }

            set
            {
                this[key] = value;
            }
        }

        public int Count
        {
            get { return countEntries - 1; }
        }

        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            this.Add(item.Key, item.Value);
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetHash(key);
            previous = buckets[index];
            if (previous == 0) previous = -1;//to know the last reference
            AddIfEmpty(key, value, index);
            items[countEntries] = new Entry(key, value, previous);
            buckets[index] = countEntries++;
        }

        public void Clear()
        {
            countEntries = 0;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (ContainsKey(item.Key))
            {
                Entry entry = GetEntry(item);
                if (entry.previous != 0) return true;
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            if (buckets[GetHash(key)] > 0)
            {
                for (int i = 1; i <= countEntries + 1; i++)
                {
                    if (items[i].TKey.Equals(key)) return true;
                }
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            int k = arrayIndex;
            int j = 1;
            for (var i = items[j].TValue; !items[j].TValue.Equals(default(TValue)); i = items[j].TValue)
            {
                array.SetValue(i, k++);
            }
        }

        public bool Remove(TKey key)
        {
            int lastIndex = GetHash(key);
            if (ContainsKey(key))
            {
                int freeIndex = buckets[lastIndex];
                while (freeIndex != 0)
                {
                    freeIndex = items[freeIndex].previous;
                    if (freeIndex != -1)
                    {
                        items[freeIndex] = default(Entry);
                        freeIndex = items[freeIndex].previous;
                        countEntries--;
                    }
                    items[freeIndex] = default(Entry);
                    countEntries--;
                    freeIndex = items[freeIndex].previous;
                }
                buckets[lastIndex] = 0;
                return true;
            }
            return false;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (Contains(item))
            {
                for (int i = buckets[GetHash(item.Key)]; i != 0; i = items[i].previous)
                {
                    if (items[i].TValue.Equals(item.Value))
                    {
                        items[i] = default(Entry);
                        freeIndex = items[i].previous;
                        countEntries--;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {

            for (int i = buckets[GetHash(key)]; i != 0; i = items[i].previous)
            {
                value = items[i].TValue;
                if (items[i].TValue.Equals(value)) return true;
            }
            value = default(TValue);
            return false;
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
        {
            for (var i = items[countEntries]; countEntries != 0; i = items[--countEntries])
            {
                yield return new KeyValuePair<TKey, TValue>(i.TKey, i.TValue);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = items[countEntries]; countEntries != 0; i = items[--countEntries])
            {
                yield return i.TValue;
            }
        }

        private int GetHash(TKey hashCode)
        {
            return hashCode.GetHashCode() % buckets.Length;
        }

        private Entry GetEntry(KeyValuePair<TKey, TValue> item)
        {
            for (int i = buckets[GetHash(item.Key)]; i != 0; i = items[i].previous)
            {
                if (items[i].TValue.Equals(item.Value)) return items[i];
            }
            return default(Entry);
        }

        private void AddIfEmpty(TKey key, TValue value, int index)
        {
            while (freeIndex > 0)
            {
                items[freeIndex] = new Entry(key, value, previous);
                buckets[index] = countEntries++;
                freeIndex = items[freeIndex].previous;
            }
        }
        private int IndexOf(int item)
        {
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i].Equals(item)) return i;
            }
            return -1;
        }
    }
}
