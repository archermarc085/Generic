using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass<T> where T : class,new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
