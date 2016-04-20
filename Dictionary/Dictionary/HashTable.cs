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
        Entries[] items = new Entries[10];
        int countEntries = 1;
        int previous = 0;
        int[] freeSlots = new int[10];
        int freeIndex = 0;
        int theSlot = 0;

        public struct Entries
        {
            public TKey TKey;
            public TValue TValue;
            public int previous;

            public Entries(TKey TKey, TValue TValue, int previous)
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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
            items[countEntries] = new Entries(key, value, previous);
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
                Entries entry = GetEntry(item);
                if (entry.previous != 0) return true;
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            return buckets[GetHash(key)] > 0;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            int lastIndex = GetHash(key);
            int k = 0;
            if (ContainsKey(key))
            {
                int i = buckets[lastIndex];
                while(i != 0)
                {
                    freeSlots[freeIndex++] = i;

                    k = items[i].previous;
                    if(k != -1)
                    {
                        freeSlots[freeIndex++] = k;
                        items[k] = default(Entries);
                        countEntries--;
                    }
                    items[i] = default(Entries);
                    countEntries--;
                    i = items[i].previous;
                }
                buckets[lastIndex] = 0;
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
                        freeSlots[freeIndex++] = i;
                        items[i] = default(Entries);
                        countEntries--;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (ContainsKey(key))
            {

                for (int i = buckets[GetHash(key)]; i != 0; i = items[i].previous)
                {
                    value = items[i].TValue;
                    if (items[i].TValue.Equals(value)) return true;
                }
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

        private Entries GetEntry(KeyValuePair<TKey, TValue> item)
        {
            for (int i = buckets[GetHash(item.Key)]; i != 0; i = items[i].previous)
            {
                if (items[i].TValue.Equals(item.Value)) return items[i];
            }
            return default(Entries);
        }

        private void AddIfEmpty(TKey key, TValue value, int index)
        {
            if (freeSlots.Length > 0)
            {
                while (theSlot != 0)
                {
                    int theIndex = freeSlots[theSlot];
                    items[theSlot] = new Entries(key, value, previous);
                    buckets[index] = countEntries++;
                    freeSlots[theSlot] = 0;
                    theSlot--;
                    freeIndex--;
                }
            }
        }
    }
}
