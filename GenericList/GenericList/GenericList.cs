using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
	public class GenericList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
    {
        T[] array = new T[5];
            
        public T this[int index]
        { 
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Count 
        {
            get { return array.Length; } 
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
			int i;
			i = array.Length;
			Array.Resize(ref array, i++);
            array[i] = item;
		}

        public void Clear()
        {
            for (int i=0; i < array.Length; i++)
                array[i] = default(T);
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //if (array[i] == item)
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
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
