using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Enter_Numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int Start = 1;
            int End = 100;
            int count = 10;
            ReadNumbers(Start, End, count);
        }

        public static void ReadNumbers(int Start, int End, int count)
        {
            int n = 0;
            for (int i = count; i >= 1; i--)
            {
            enterAgain :
                try
                {
                    Console.WriteLine("Enter a int number between {0} and {1}", Start, End);                   
                    n = int.Parse(Console.ReadLine());
                    if (!(Start < n && n < End))
                    {
                        while (!(Start < n && n < End))
                        {
                            Console.WriteLine("You entered number out of range");
                            Console.WriteLine("Please enter a new number between {0} and {1}: ", Start, End);
                            n = int.Parse(Console.ReadLine());
                        }
                    }
                    Start = n;     
                }
                catch (FormatException)
                {
                    Console.WriteLine("The entered value is not a int number");
                    goto enterAgain;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered number out of range");
                    goto enterAgain;
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Enter {0} more numbers", i-1);
                Console.WriteLine("------------------------------------------");
                if (n == End-1)
                {
                    Console.WriteLine("Enter a int number between {0} and {1}", Start, End);
                    Console.WriteLine("There is no int numbers between {0} and {1}", Start, End);
                    break;
                }
            }
        }
    }
    
}
