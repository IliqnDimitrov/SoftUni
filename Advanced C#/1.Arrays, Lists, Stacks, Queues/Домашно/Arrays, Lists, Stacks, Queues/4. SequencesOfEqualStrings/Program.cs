using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequencesOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input.Length == 1)
            {
                Console.WriteLine("{0}",input[0]);
            }

            for (int currentIndex = 1; currentIndex < input.Length; currentIndex++)
            {
                if (input[currentIndex-1] == input[currentIndex])
                {
                    Console.Write("{0} ", input[currentIndex]);
                    for (int j = currentIndex; j < input.Length; j++)
                    {
                        if (input[currentIndex-1] == input[j])
                        {
                            Console.Write("{0} ",input[j]);
                            currentIndex++;
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0}",input[currentIndex-1]);
                }
                if (currentIndex == input.Length-1)
                {
                    Console.WriteLine("{0}",input[currentIndex]);
                }
                
            }
        }
    }
}
