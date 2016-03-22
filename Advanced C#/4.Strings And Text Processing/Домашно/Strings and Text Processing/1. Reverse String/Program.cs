using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IEnumerable<char> reversedInput = input.Reverse();
            Console.WriteLine(string.Join("",reversedInput));
        }
    }
}
