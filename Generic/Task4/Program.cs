using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Auto auto1 = new Auto();

            MyList<Auto> myauto = new MyList<Auto>();
            myauto.Add(auto);
            myauto[0].Name = "Audi";
            myauto.Add(auto1);
            myauto.Add(new Auto());
            // myauto.Remove(1);
            //Console.WriteLine(myauto[1].Name);
            myauto.GetArray<Auto>();
            Console.WriteLine(myauto.Count);
            Console.ReadLine();
        }
    }
}
