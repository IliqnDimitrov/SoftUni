using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            foreach (var item in input)
            {
                Console.Write(@"\u{0:x4}",(int)item);
            }
            Console.WriteLine();
        }
    }
}
