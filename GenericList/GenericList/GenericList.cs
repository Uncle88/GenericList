using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    public class GenericList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
    {
        T[] array = new T[5];
        T[] massiv = new T[5];

        #region Properties
        public int Count
        {
            get { return array.Length; }
}
        public T this[int index]
        {
            get { return array[index]; }
            set 
            { 
               if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("The specified index is out of range.");
                array[index] = value; 
            }
        }

        object IList.this[int index] 
        { 
            get { return (IList)array[index]; }
            set 
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("The specified index is out of range.");
                ((IList)array)[index] = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        #endregion

        #region Methods
        public void Add(T item)
        {
            int i = array.Length;
            Array.Resize(ref array, i++);
            array[i] = item;
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = default(T);
        }

        public bool Contains(T item)
        {
            if (item == null)
                return false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].GetType() != item.GetType())
                    return false;
            }
            return true;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex != null && arrayIndex >= 0)
            {
                for (int i = arrayIndex; i < array.Length; i++)
                    for (int j = 0; j < array.Length; j++)
                        massiv[j] = array[i];
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                    return i;
            }
            return 0;
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            if ((index < Count) && (index >= 0))
            {
                for (int i = Count - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = item;
            }
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (item == null)
                return false;
            for (int i = 0; i < Count; i++)
                if (array.Equals(item))
                {
                    array[i] = default(T);
                    return true;
                }
            return false;
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            if (index >= 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (array.Equals(index))
                    {
                        array[i] = default(T);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
