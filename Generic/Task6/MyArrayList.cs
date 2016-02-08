using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class MyArrayList : IEnumerable
    {
        int size = 0;
        int count = 0;
        object[] array;

        public int Count
        {
            get { return count; }
        }

        public object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public MyArrayList()
            : this(10)
        {

        }
        public MyArrayList(int capacity)
        {
            size = capacity;
            array = new object[size];
        }
        public void Add(object obj)
        {
            if (array.Length > count)
            {
                array[count] = obj;
                count++;
            }
            else
            {
                size++;
                Array.Resize<object>(ref array, size);
                array[count] = obj;
                count++;
            }
        }
        public object Get(int index)
        {
            return array[index];
        }
        public void Remove(int index)
        {
            array[index] = null;
            count--;
        }
        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
