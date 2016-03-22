using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _3.CategorizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<int> integers = new List<int>();
            List<float> floats = new List<float>();
            for (int i = 0; i < input.Length; i++)
            {
                floats.Add(Convert.ToSingle(input[i]));
            }
            for (int i = 0; i < floats.Count; i++)
            {
                int output;
                bool successfullyParsed = int.TryParse(floats[i].ToString(), out output);
                if (successfullyParsed)
                {
                    integers.Add(Convert.ToInt32(floats[i]));
                    floats.RemoveAt(i);
                    i--;
                }
                
            }
            Console.Write("[{0}]",string.Join(", ",floats));
            Console.WriteLine(" -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}",floats.Min(),floats.Max(),floats.Sum(),floats.Average());
            Console.Write("[{0}]",string.Join(", ",integers));
            Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",integers.Min(),integers.Max(),integers.Sum(),integers.Average());
        }
    }
}
