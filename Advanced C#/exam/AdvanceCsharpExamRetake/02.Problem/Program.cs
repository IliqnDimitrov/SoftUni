using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger money = 50;
            int turns = 0;
            BigInteger xaxa = 0;
            BigInteger product = 0;
            List<string> hotels = new List<string>();
            string[] cowRow = Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries);
            int row = Convert.ToInt32(cowRow[0]);
            int col = Convert.ToInt32(cowRow[1]);
            string[][] field = new string[row][];
            for (int i = 0; i < field.Length; i++)
            {
                string input = Console.ReadLine();
                field[i] = new string[col];
                for (int j = 0; j < col; j++)
                {
                    field[i][j] = input[j].ToString();
                }
            }

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    switch (field[i][j])
                    {
                        case "H":
                            hotels.Add("hotel");
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.",money,hotels.Count);
                            money = 0;
                            break;
                        case "J":
                            Console.WriteLine("Gone to jail at turn {0}.",turns);
                            turns ++;
                            if (hotels.Count != 0)
                            {
                                money += hotels.Count * 10;
                            }                           
                            turns ++;
                            if (hotels.Count != 0)
                            {
                                money += hotels.Count * 10;
                            }
                            break;
                        case "S":
                            if (money - ((i + 1) * (j + 1)) >= 0)
                            {
                                money = money - ((i + 1) * (j + 1));
                                product = ((i + 1)*(j + 1));
                            }
                            else
                            {
                                product = money;
                                money = 0;
                            }                          
                            Console.WriteLine("Spent {0} money at the shop.",product);
                            break;
                        case "F":
                            break;
                    }
                    turns++;
                    if (hotels.Count != 0)
                    {
                        money += hotels.Count * 10;
                    }                  
                }
                if (i == field.Length - 1)
                {
                    break;
                }
                i++;
                for (int j = field[i].Length - 1; j >= 0; j--)
                {
                    switch (field[i][j])
                    {
                        case "H":
                            hotels.Add("hotel");
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, hotels.Count);
                            money = 0;
                            break;
                        case "J":
                            Console.WriteLine("Gone to jail at turn {0}.", turns);
                            turns ++;
                            if (hotels.Count != 0)
                            {
                                money += hotels.Count * 10;
                            }
                            turns ++;
                            if (hotels.Count != 0)
                            {
                                money += hotels.Count * 10;
                            }
                            break;
                        case "S":
                            if (money - ((i + 1) * (j + 1)) >= 0)
                            {
                                money = money - ((i + 1) * (j + 1));
                                product = ((i + 1)*(j + 1));
                            }
                            else
                            {
                                product = money;
                                money = 0;
                            }                          
                            Console.WriteLine("Spent {0} money at the shop.",product);
                            break;
                        case "F":
                            break;
                    }
                    turns++;
                    if (hotels.Count != 0)
                    {
                        money += hotels.Count * 10;
                    }
                }
            }
            Console.WriteLine("Turns {0}",turns);
            Console.WriteLine("Money {0}",money);
        }
    }
}
