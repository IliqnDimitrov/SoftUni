using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prime_Factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int divisor = 2;
            int input2 = input;
            List<int> primeNumbers = new List<int>();
            while (input2 > 1)
            {
                if (input2 > 1)
                {
                    if (divisor % 2 != 0 || divisor % 3 != 0 || divisor % 5 != 0 || divisor % 7 != 0 || divisor == 2 || divisor == 3 || divisor == 5 || divisor == 7)
                    {
                        if (input2 % divisor == 0)
                        {
                            primeNumbers.Add(divisor);
                            input2 = input2 / divisor;
                        }
                    }
                }
                else
                {
                    break;
                }
                if (input2 % divisor != 0)
                {
                    divisor++;
                }
            }
      
            Console.WriteLine("{0} = {1}", input, string.Join(" * ", primeNumbers));
        }
    }
}
