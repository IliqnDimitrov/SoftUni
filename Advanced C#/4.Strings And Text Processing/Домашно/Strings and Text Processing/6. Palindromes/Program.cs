using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separatos = {'.', ',', '!', ' ', '?'};

            string[] input = Console.ReadLine().Split(separatos, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var reversedInput = input[i].Reverse();
                if (input[i] == string.Join("",reversedInput))
                {
                    palindromes.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ",palindromes));
        }
    }
}
