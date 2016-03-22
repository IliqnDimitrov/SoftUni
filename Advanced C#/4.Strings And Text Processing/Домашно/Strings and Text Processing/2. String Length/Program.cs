using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] newString = new char[20];
            for (int i = 0; i < input.Length; i++)
            {
                if (i == newString.Length)
                {
                    break;
                }
                newString[i] = input[i];
            }
            for (int i = 19; i > 0; i--)
            {
                if (newString[i] == 0)
                {
                    newString[i] = '*';
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(string.Join("",newString));
        }
    }
}
