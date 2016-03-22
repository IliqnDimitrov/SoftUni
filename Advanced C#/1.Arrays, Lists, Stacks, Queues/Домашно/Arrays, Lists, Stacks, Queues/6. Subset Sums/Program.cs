using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Subset_Sums
{
    class Program
    {
        private static int n;
        private static bool solution = false;
        private static int[] numbers;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> subset = new List<int>();
            numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            MakeSubset(0, subset);

            if (solution == false)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        public static void MakeSubset(int index, List<int> subset)
        {
            int sum = subset.Sum();

            if (sum == n)
            {
                Console.WriteLine("{0} = {1}",string.Join(" + ",subset),n);
                solution = true;
            }

            if (subset.Count == numbers.Length)
            {
                return;
            }

            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);

                MakeSubset(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
