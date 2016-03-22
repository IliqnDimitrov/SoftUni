using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] inputSequence = Console.ReadLine().Split(new char[' '],StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var r = Console.ReadLine();
            int index = 0;
            while (r != "stop")
            {
                var ee = r.Split(' ');
                int a = int.Parse(ee[0]);
                var b = ee[1];
                var c = long.Parse(ee[2]);
                a = a % inputSequence.Length;
                index += a;
                var pos = index % inputSequence.Length;
                if (pos < 0)
                {
                    pos += inputSequence.Length;
                }
                if (pos >= inputSequence.Length)
                {
                    pos -= inputSequence.Length;
                }
                switch (b)
                {
                    case "+":
                        if ((inputSequence[pos] + c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] + c;
                        break;
                    case "-":
                        if (inputSequence[pos] < c)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] - c;
                        break;
                    case "*":
                        if ((inputSequence[pos] * c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] * c;
                        break;
                    case "/":
                        if ((inputSequence[pos] / c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] / c;
                        break;
                    case "&":
                        if ((inputSequence[pos] & c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] & c;
                        break;
                    case "|":
                        if ((inputSequence[pos] | c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] | c;
                        break;
                    case "^":
                        if ((inputSequence[pos] ^ c) < 0)
                        {
                            inputSequence[pos] = 0;
                        }
                        else inputSequence[pos] = inputSequence[pos] ^ c;
                        break;
                }
                r = Console.ReadLine();
            }
            for (int qq = 0; qq < inputSequence.Length; qq++)
            {
                if (inputSequence[qq] < 0)
                {
                    inputSequence[qq] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", inputSequence) + "]");
        }
    }
}