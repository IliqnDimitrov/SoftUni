using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            var list = new CustomList<int>();
            list.Add(25);
            list.Add(10);
            list.Add(15);
            list.Add(56);
            Console.WriteLine(list);
            list.Remove(25);           
            Console.WriteLine(list);
            Console.WriteLine("Index of 15: {0}", list.IndexOf(15));

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());


        }
    }
}
