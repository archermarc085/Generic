using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arraylist = new MyArrayList();
            arraylist.Add(1);
            arraylist.Add(0.485637534);
            arraylist.Add("system");

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
