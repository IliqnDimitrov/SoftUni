using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {           
            try
            {
                Console.Write("Enter a int number: ");
                int n = int.Parse(Console.ReadLine());               
                if (n < 0)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {
                    Console.WriteLine("Square root of this number is: " + Math.Sqrt(n));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
