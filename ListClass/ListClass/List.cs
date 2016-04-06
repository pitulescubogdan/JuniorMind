using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class List<T> : IList<T>
    {
        T[] stored = new T[0];

        public T this[int index]
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
            get
            {
                int count = 0;
                for (int i = 0; i < stored.Length; i++)
                {
                    if (!stored[i].Equals(0))
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            if (stored.Length == 0) Array.Resize(ref stored, 1);
            for (int i = 0; i < stored.Length; i++)
            {
                if (i == stored.Length - 1)
                {
                    Array.Resize(ref stored, stored.Length * 2);
                }
                if (stored[i].Equals(0))
                {
                    stored[i] = item;
                    return;
                }
            }
        }

        public void Clear()
        {
            Array.Resize(ref stored, 0);
        }

        public bool Contains(T item)
        {
            for(int i = 0; i < stored.Length; i++)
            {
                if (stored[i].Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i < stored.Length; i++)
            {
                if (stored[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
