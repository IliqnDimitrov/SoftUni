using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Array_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int[] result = new int[inputNumbers.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToInt32(inputNumbers[i]);
            }

            Array.Sort(result);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
