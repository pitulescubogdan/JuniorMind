using System;
using System.Collections;
using System.Collections.Generic;


namespace List
{
    public class List<T> : IList<T>
    {
        T[] stored = new T[7];
        int count = 0;

        public T this[int index]
        {
            get
            {
                return stored[index];
            }

            set
            {
                stored[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            MakeSpace();
            stored[count] = item;
            count++;
            return;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < stored.Length; i++)
            {
                if (stored[i].Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int index)
        {
            int k = index;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(stored[i], k++);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return stored[i];
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < stored.Length; i++)
            {
                if (stored[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            MakeSpace();

            for (int i = stored.Length - 1; i > index; i--)
            {
                stored[i] = stored[i - 1];
                count++;
            }
            stored[index] = item;

        }

        public bool Remove(T item)
        {
            if (Contains(item))
            {
                RemoveAt(IndexOf(item));
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < stored.Length)
            {
                Array.Copy(stored, index + 1, stored, index, stored.Length - index - 1);
                stored[stored.Length - index - 1] = default(T);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void MakeSpace()
        {
            if (count == stored.Length - 1)
            {
                Array.Resize(ref stored, stored.Length * 2);
            }
        }
    }
}
