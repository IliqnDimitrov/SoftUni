using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] read = Console.ReadLine().Split();
            int[] input = new int[read.Length];
            for (int i = 0; i < read.Length; i++)
            {
                input[i] = Convert.ToInt32(read[i]);
            }

            int[][] matrixSums = new int[input[0]][];

            for (int i = 0; i < matrixSums.Length; i++)
            {
                string[] inputCols = Console.ReadLine().Split();
                matrixSums[i] = new int[inputCols.Length];
                for (int j = 0; j < inputCols.Length; j++)
                {
                    matrixSums[i][j] = int.Parse(inputCols[j]);
                }
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            
            for (int row = 0; row < matrixSums.Length - 2; row++)
            {
                for (int col = 0; col < input[1] - 2; col++)
                {
                    int sum = matrixSums[row][col] +
                              matrixSums[row + 1][col] +
                              matrixSums[row][col + 1] +
                              matrixSums[row + 1][col + 1] +
                              matrixSums[row][col + 2] +
                              matrixSums[row + 1][col + 2] +
                              matrixSums[row + 2][col + 2] +
                              matrixSums[row + 2][col + 1] +
                              matrixSums[row + 2][col];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            int[][] bestSums = new[]
            {
                new[] {matrixSums[bestRow][bestCol], matrixSums[bestRow][bestCol + 1], matrixSums[bestRow][bestCol + 2]},
                new[]
                {
                    matrixSums[bestRow + 1][bestCol], matrixSums[bestRow + 1][bestCol + 1],
                    matrixSums[bestRow + 1][bestCol + 2]
                },
                new[]
                {
                    matrixSums[bestRow + 2][bestCol], matrixSums[bestRow + 1][bestCol + 1],
                    matrixSums[bestRow + 2][bestCol + 2]
                }
            };
            Console.WriteLine();
            Console.WriteLine("Sum = {0}", bestSum);
            foreach (var subArray in bestSums)
            {
                foreach (var items in subArray)
                {
                    string a = Convert.ToString(items);
                    Console.Write("{0} ",a.PadRight(2));
                }
                Console.WriteLine();
            }

        }
    }
}
