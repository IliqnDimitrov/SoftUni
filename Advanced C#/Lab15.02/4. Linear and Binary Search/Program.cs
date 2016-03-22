using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _4.Linear_and_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int searchElement = int.Parse(Console.ReadLine());

            int[] result = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                result[i] = Convert.ToInt32(inputNumbers[i]);
            }

            Console.WriteLine(BinarySearch(result, searchElement, 0, result.Length));
            
        }


        public static int BinarySearch(int[] x, int searchValue, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }


            int mid = (left + right) >> 1;


            if (searchValue > x[mid])
            {
                return BinarySearch(x, searchValue, mid + 1, right);
            }
            else if (searchValue < x[mid])
            {
                return BinarySearch(x, searchValue, left, mid - 1);
            }
            else if (searchValue == x[mid])
            {
                for (int i = left; i < right; i++)
                {
                    if (x[i] == searchValue)
                    {
                        return i;
                    }
                }

                return mid;
            }

            return -1;
        }
    }
}
