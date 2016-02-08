using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
        where TKey : class
        where TValue : class
    {
        int size = 0;
        private int count = 0;
        private TKey[] keys = null;
        private TValue[] vals = null;

        public int Count
        {
            get { return count; }
        }
        public MyDictionary()
        {

        }
        public void Add(TKey key, TValue val)
        {
            if (size > count)
            {
                keys[count] = key;
                vals[count] = val;
                count++;
            }
            else
            {
                count++;
                Array.Resize(ref keys, count);
                keys[count - 1] = key;
                Array.Resize(ref vals, count);
                vals[count - 1] = val;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (key.Equals(keys[i]))
                        ind = i;
                }
                return vals[ind];
            }
        }
    }
}
