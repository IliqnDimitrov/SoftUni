using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Mitko = new Person("Mitko",25,"Mitko@abv.bg");
            Person Gosho = new Person("Gosho",45);
            Console.WriteLine(Mitko);
            Console.WriteLine();
            Console.WriteLine(Gosho);
        }
    }
}
