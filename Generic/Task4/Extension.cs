using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Extension
    {
        public static T[] GetArray<T>(this MyList<T> list) where T : Auto
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.array[i].Name);
            }
            return list.array;
        }

        /* public static T[] GetArray<D>(this MyList<T> list) where T : class
         {
             for (int i = 0; i < list.Count; i++)
             {
                 Console.WriteLine(list.array[i]);
             }
             return list.array;
         }*/
    }
}
