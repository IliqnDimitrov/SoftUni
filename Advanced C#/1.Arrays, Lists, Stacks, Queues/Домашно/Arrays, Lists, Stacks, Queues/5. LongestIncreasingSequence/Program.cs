using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(Convert.ToInt32(input[i]));
            }

            List<int> sequence = new List<int>();
            List<int> sequence1 = new List<int>();
            List<int> longSequence = new List<int>();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] >= numbers[i])
                {
                    if (sequence.Count != 0)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sequence1.Add(numbers[j]);
                        }
                        numbers.RemoveRange(0, i);
                        Console.WriteLine(string.Join(" ", sequence1));                                              
                        longSequence = Program.CompareLists(longSequence, sequence1);
                        longSequence = Program.CreateSequence(longSequence);
                        sequence.Clear();
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sequence.Add(numbers[j]);
                        }
                        numbers.RemoveRange(0, i);
                        Console.WriteLine(string.Join(" ", sequence));
                        if (longSequence.Count != 0)
                        {
                            longSequence = Program.CompareLists(sequence, longSequence);
                        }
                        else
                        {
                            longSequence = Program.CompareLists(sequence, sequence1);                            
                        }
                        
                        sequence1.Clear();
                    }
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
            longSequence = Program.CompareLists(longSequence, numbers);
            Console.WriteLine("Longest: {0}", string.Join(" ", longSequence));
            
        }

        private static List<int> CompareLists(List<int> sequence, List<int> sequence2)
        {
            List<int> longestSequence = new List<int>();
            if (sequence.Count > sequence2.Count)
            {
                longestSequence = sequence;
            }
            else if (sequence2.Count > sequence.Count)
            {
                longestSequence = sequence2;
            }
            else if (sequence2.Count == sequence.Count)
            {
                if (sequence2[sequence2.Count-1] > sequence[sequence.Count-1])
                {
                    longestSequence = sequence2;
                }
                else
                {
                    longestSequence = sequence;
                }
            }
            return longestSequence;
        }

        private static List<int> CreateSequence(List<int> sequenceList)
        {
            List<int> lSequence = new List<int>();
            foreach (var items in sequenceList)
            {
                lSequence.Add(items);
            }
            return lSequence;
        }
    }
}
