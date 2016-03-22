using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedList = Console.ReadLine().Split(new []{','},StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            for (int i = 0; i < bannedList.Length; i++)
            {
                input = input.Replace(bannedList[i], new string('*', bannedList[i].Length));
            }
            Console.WriteLine(input);
        }
    }
}
