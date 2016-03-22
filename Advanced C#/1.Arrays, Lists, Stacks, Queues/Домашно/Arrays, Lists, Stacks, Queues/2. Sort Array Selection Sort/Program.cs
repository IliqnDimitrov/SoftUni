using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sort_Array_Selection_Sort
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
            SelectionSort(result);
        }

        public static void SelectionSort(int[] array)
        {
            for (int startIndex = 0; startIndex < array.Length - 1; startIndex++)
            {
                int currentMinimumIndex = startIndex;

                for (int currentIndex = startIndex + 1; currentIndex < array.Length; currentIndex++)
                {
                    if (array[currentMinimumIndex] > array[currentIndex])
                    {
                        currentMinimumIndex = currentIndex;
                        
                    }
                  
                }
                var swapIndex = array[startIndex];
                array[startIndex] = array[currentMinimumIndex];
                array[currentMinimumIndex] = swapIndex;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
