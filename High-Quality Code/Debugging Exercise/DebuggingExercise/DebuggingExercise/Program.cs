using System.Linq;

namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
                

                int[] numbers = new int[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    numbers[j] = Convert.ToInt32(input[j]);
                }

                bool found = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                    }
                    else
                    {

                        if (j+1 < numbers.Length)
                        {
                            currentNum += numbers[j + 1];
                            
                        }

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;

                            j++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}