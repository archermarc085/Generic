using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, Auto> auto = new MyDictionary<string, Auto>();
            Auto car = new Auto();
            auto.Add("Car", car);
            auto["Car"].Name = "Audi";
            Console.WriteLine(auto["Car"].Name);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
