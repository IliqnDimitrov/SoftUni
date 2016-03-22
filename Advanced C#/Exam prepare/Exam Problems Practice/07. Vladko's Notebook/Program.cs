using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vladko_s_Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colourName = new Dictionary<string, string>();
            Dictionary<string, string> colourAge = new Dictionary<string, string>();
            Dictionary<string, List<string>> colourOpponents = new Dictionary<string, List<string>>();
            Dictionary<string , int> colourWins = new Dictionary<string, int>();
            Dictionary<string, int> colourLoss = new Dictionary<string, int>();
            SortedSet<string> colours = new SortedSet<string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string colour = null;
                string[] elements = input.Split('|');
                colour = elements[0];
                colours.Add(colour);
                if (elements[1] == "name")
                {
                    if (!colourName.ContainsKey(colour))
                    {
                        colourName.Add(colour, elements[2]);
                    }                   
                }
                else if (elements[1] == "age")
                {
                    if (!colourAge.ContainsKey(colour))
                    {
                        colourAge.Add(colour, elements[2]);
                    }                 
                }
                else if (elements[1] == "win" || elements[1] == "loss")
                {
                    if (colourOpponents.ContainsKey(colour))
                    {
                        colourOpponents[colour].Add(elements[2]);
                    }
                    else
                    {
                        colourOpponents.Add(colour, new List<string>());
                        colourOpponents[colour].Add(elements[2]);
                    }
                    if (elements[1] == "win")
                    {
                        if (colourWins.ContainsKey(colour))
                        {
                            colourWins[colour] += 1;
                        }
                        else
                        {
                            colourWins.Add(colour, 1);
                            colourWins[colour] += 1;
                        }                      
                    }
                    else if (elements[1] == "loss")
                    {
                        if (colourLoss.ContainsKey(colour))
                        {
                            colourLoss[colour] += 1;
                        }
                        else
                        {
                            colourLoss.Add(colour, 1);
                            colourLoss[colour] += 1;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            bool isAny = false;
            foreach (var color in colours)
            {
                if (colourName.ContainsKey(color) && colourAge.ContainsKey(color))
                {
                    isAny = true;
                    break;
                }
                else
                {
                    isAny = false;
                }
            }
            if (!isAny)
            {
                Console.WriteLine("No data recovered.");
                Environment.Exit(0);
            }

            foreach (var color in colours)
            {
                if (colourName.ContainsKey(color) && colourAge.ContainsKey(color))
                {
                    Console.WriteLine("Color: {0}", color);
                    Console.WriteLine("-age: {0}",colourAge[color]);
                    Console.WriteLine("-name: {0}",colourName[color]);
                    if (colourOpponents.ContainsKey(color))
                    {
                        Console.WriteLine("-opponents: {0}", string.Join(", ", colourOpponents[color].OrderBy(x => !Char.IsUpper(x[0])).ThenBy(s => s)));
                    }
                    else
                    {
                        Console.WriteLine("-opponents: (empty)");
                    }
                    if (colourWins.ContainsKey(color) && colourLoss.ContainsKey(color))
                    {
                        Console.WriteLine("-rank: {0:F2}", (double)colourWins[color] / colourLoss[color]);
                    }
                    else if (colourWins.ContainsKey(color))
                    {
                        Console.WriteLine("-rank: {0:F2}", colourWins[color] / 1.0);
                    }
                    else if (colourLoss.ContainsKey(color))
                    {
                        Console.WriteLine("-rank: {0:F2}", 1.0 / colourLoss[color]);
                    }
                    else
                    {
                        Console.WriteLine("-rank: 1.00");
                    }
                }
            }
        }
    }
}
