using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MyList<T> : IEnumerable
     where T : class
    {
        public T[] array;
        int count = 0;
        public int Count { get { return count; } }
        public T this[int index]
        {
            get { return (T)array[index]; }
        }
        public MyList()
        {
            array = new T[10];
        }
        public T Get(int index)
        {
            return array[index];
        }
        public void Add(T obj)
        {
            for (int i = count; i < array.Length; i++)
            {
                array[i] = obj;
            }
            count++;
        }

        public void Remove(int index)
        {
            array[index] = null;
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
