using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w]{1})(?!\1)";
            Regex ragex = new Regex(pattern);
            MatchCollection result = ragex.Matches(input);
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
