using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            string searchedText = Console.ReadLine();

            int Count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > searchedText.Length)
                {
                    for (int j = 0; j <= input[i].Length - searchedText.Length; j++)
                    {
                        if (input[i].Substring(j, searchedText.Length) == searchedText)
                        {
                            Count++;
                        }
                    }
                }
            }
            Console.WriteLine(Count);
        }
    }
}
