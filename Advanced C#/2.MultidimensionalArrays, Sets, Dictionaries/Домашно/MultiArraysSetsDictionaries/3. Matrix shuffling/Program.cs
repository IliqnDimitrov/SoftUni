using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml;

namespace _3.Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());
            int matrixCols = int.Parse(Console.ReadLine());
            string[][] matrixSums = new string[matrixRows][];

            for (int i = 0; i < matrixSums.Length; i++)
            {
                matrixSums[i] = new string[matrixCols];
                for (int j = 0; j < matrixCols; j++)
                {
                    matrixSums[i][j] = Console.ReadLine();
                }
            }

            string commandInput = string.Empty;
            while (commandInput != "END")
            {
                commandInput = Console.ReadLine();
                if (commandInput.Contains("swap"))
                {
                    try
                    {
                        commandInput = commandInput.Remove(0, 4);
                        string[] CoordinateToSwap = commandInput.Trim().Split(' ');
                        int[] toSwap = Array.ConvertAll(CoordinateToSwap, int.Parse);
                        string temp = matrixSums[toSwap[0]][toSwap[1]];
                        matrixSums[toSwap[0]][toSwap[1]] = matrixSums[toSwap[2]][toSwap[3]];
                        matrixSums[toSwap[2]][toSwap[3]] = temp;
                        foreach (var array in matrixSums)
                        {
                            foreach (var item in array)
                            {
                                Console.Write("{0} ",item);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (commandInput == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
