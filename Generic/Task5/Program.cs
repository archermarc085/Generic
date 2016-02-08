using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Auto> auto = new CarCollection<Auto>();
            auto.AddCar("Lexus", 200, 60000);
            auto.AddCar("Mazda", 150, 20000);
            auto.AddCar("BMW", 210, 40000);
            auto.SortByPrice();

            foreach (Auto item in auto)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Count:{0} ", auto.Count);
            Console.ReadLine();
        }
    }
}
