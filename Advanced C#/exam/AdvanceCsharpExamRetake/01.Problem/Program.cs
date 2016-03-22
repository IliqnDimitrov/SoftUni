using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int, string> numbers = new Dictionary<int, string>();
            int key = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 0:
                        numbers.Add(key, "zero");
                        break;
                    case 1:
                        numbers.Add(key, "one");
                        break;
                    case 2:
                        numbers.Add(key, "two");
                        break;
                    case 3:
                        numbers.Add(key, "three");
                        break;
                    case 4:
                        numbers.Add(key, "four");
                        break;
                    case 5:
                        numbers.Add(key, "five");
                        break;
                    case 6:
                        numbers.Add(key, "six");
                        break;
                    case 7:
                        numbers.Add(key, "seven");
                        break;
                    case 8:
                        numbers.Add(key, "eight");
                        break;
                    case 9:
                        numbers.Add(key, "nine");
                        break;

                }
                if (input[i] > 9)
                {
                    string xaxa = input[i].ToString();
                    string theNumber = null;
                    for (int j = 0; j < xaxa.Length; j++)
                    {
                        switch (xaxa[j])
                        {
                            case '0':
                                theNumber += "zero";
                                break;
                            case '1':
                                theNumber += "one";
                                break;
                            case '2':
                                theNumber += "two";
                                break;
                            case '3':
                                theNumber += "three";
                                break;
                            case '4':
                                theNumber += "four";
                                break;
                            case '5':
                                theNumber += "five";
                                break;
                            case '6':
                                theNumber += "six";
                                break;
                            case '7':
                                theNumber += "seven";
                                break;
                            case '8':
                                theNumber += "eight";
                                break;
                            case '9':
                                theNumber += "nine";
                                break;

                        }
                        if (j == xaxa.Length - 1)
                        {
                            numbers.Add(key, theNumber);
                            break;
                        }
                        theNumber += "-";
                    }
                }
                key++;
            }

            int count = 0;
            foreach (var item in numbers.OrderBy(x => x.Value))
            {
                
                if (count == input.Length - 1)
                {
                    Console.Write("{0}", input[item.Key]);
                }
                else
                {
                    Console.Write("{0}, ", input[item.Key]);
                }               
                count++;
            }
        }
    }
}
