using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Auto : IComparable
    {
        public int Speed { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Auto(string name, int speed, int price)
        {
            Name = name;
            Speed = speed;
            Price = price;
        }
        public Auto()
            : this("BMW", 230, 40000)
        {

        }
        public void Show()
        {
            Console.WriteLine(@"Name: {0}
Speed: {1} 
Price: {2}", Name, Speed, Price);
        }

        public int CompareTo(object obj)
        {
            Auto auto = (Auto)obj;
            return this.Price.CompareTo(auto.Price);
        }
    }
}
