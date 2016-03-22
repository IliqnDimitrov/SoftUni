using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            str.Append(Console.ReadLine());
            str.Replace("@", "*");
            Console.WriteLine();
            Console.WriteLine(str);
        }
    }
}
