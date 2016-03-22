using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.The_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();

            for (int i = 2; i <= 120; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    primeNumbers.Add(i);
                }
                else if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 )
                {
                    
                }
                else
                {
                    primeNumbers.Add(i);
                }
            }
            for (int i = 121; i < input; i++)
            {
                for (int j = 0; j < primeNumbers.Count; j++)
                {
                    if (i % primeNumbers[j] == 0)
                    {
                        break;
                    }
                    if (j == primeNumbers.Count-1)
                    {
                        primeNumbers.Add(i);
                    }
                }
                
            }
            Console.WriteLine(string.Join(", ",primeNumbers));
        }
    }
}
