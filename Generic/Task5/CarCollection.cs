using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CarCollection<T> : IEnumerable
        where T : class,new()
    {
        List<T> carPark = new List<T>();

        public int Count { get { return carPark.Count; } }
        public T this[int index]
        {
            get
            {
                return (T)carPark[index];
            }
        }
        public void AddCar(string name, int speed, int price)
        {
            T instance = (T)Activator.CreateInstance(typeof(T), new object[] { name, speed, price });
            carPark.Add(instance);
        }

        public void DeleteCar(int index)
        {
            carPark.RemoveAt(index);
        }

        public T Get(int index)
        {
            return (T)carPark[index];
        }
        public IEnumerator GetEnumerator()
        {
            return carPark.GetEnumerator();
        }

        public void SortByPrice()
        {
            carPark.Sort();
        }
    }
}
