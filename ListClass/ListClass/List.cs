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
                return false;
            }
        }

        public void Add(T item)
        {
            if (stored.Length == 0) Array.Resize(ref stored, 1);
            if (count == stored.Length - 1)
            {
                Array.Resize(ref stored, stored.Length * 2);
            }
            stored[count] = item;
            count++;
            return;
        }

        public void Clear()
        {
            for(int i = 0; i <stored.Length; i++)
            {
                if (!stored[i].Equals(0))
                {
                    stored[i] = default(T);
                }
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < stored.Length; i++)
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
            for (int i = 0; i < stored.Length; i++)
            {
                if (stored[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (stored.Length == 0) Array.Resize(ref stored, 1);
            while (index > stored.Length)
            {
                Array.Resize(ref stored, stored.Length * 2);
            }
            if (stored[index].Equals(0))
            {
                stored[index] = item;
                count++;
                return;
            }
            if (!stored[index].Equals(0))
            {
                Array.Resize(ref stored, stored.Length + 1);
                for (int i = stored.Length - 1; i > index; i--)
                {
                    stored[i] = stored[i - 1];
                    count++;
                }
                stored[index] = item;
                return;
            }
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
            if(index < stored.Length)
            {
                stored[index] = default(T);
                count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
