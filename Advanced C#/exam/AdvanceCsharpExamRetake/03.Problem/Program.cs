using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = 0;
            int index = 0;
            string oldContent = null;
            string newContent = null;
            int count = 1;
            while (input != "<stop/>")
            {
                try
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'i' &&
                            input[i + 1] == 'n' &&
                            input[i + 2] == 'v' &&
                            input[i + 3] == 'e' &&
                            input[i + 4] == 'r' &&
                            input[i + 5] == 's' &&
                            input[i + 6] == 'e')
                        {
                            for (int j = i + 6; j < input.Length; j++)
                            {
                                if (input[j] == '\"')
                                {
                                    for (int k = j + 1; k < input.Length; k++)
                                    {
                                        if (input[k] == '\"')
                                        {
                                            break;
                                        }
                                        oldContent += input[k];
                                    }
                                    break;
                                }
                            }
                            for (int j = 0; j < oldContent.Length; j++)
                            {
                                if (Char.IsLower(oldContent[j]))
                                {
                                    newContent += Char.ToUpper(oldContent[j]);
                                }
                                else if (Char.IsUpper(oldContent[j]))
                                {
                                    newContent += Char.ToLower(oldContent[j]);
                                }
                                else
                                {
                                    newContent += oldContent[j];
                                }
                            }
                            Console.WriteLine("{0}. {1}", count, newContent);
                            count++;
                            break;
                        }
                        else if (input[i] == 'r' &&
                            input[i + 1] == 'e' &&
                            input[i + 2] == 'v' &&
                            input[i + 3] == 'e' &&
                            input[i + 4] == 'r' &&
                            input[i + 5] == 's' &&
                            input[i + 6] == 'e')
                        {
                            for (int j = i + 6; j < input.Length; j++)
                            {
                                if (input[j] == '\"')
                                {
                                    for (int k = j + 1; k < input.Length; k++)
                                    {
                                        if (input[k] == '\"')
                                        {
                                            break;
                                        }
                                        oldContent += input[k];
                                    }
                                    break;
                                }
                            }
                            for (int j = oldContent.Length - 1; j >= 0; j--)
                            {
                                newContent += oldContent[j];
                            }
                            Console.WriteLine("{0}. {1}", count, newContent);
                            count++;
                            break;
                        }
                        else if (input[i] == 'r' &&
                            input[i + 1] == 'e' &&
                            input[i + 2] == 'p' &&
                            input[i + 3] == 'e' &&
                            input[i + 4] == 'a' &&
                            input[i + 5] == 't')
                        {
                            for (int j = i + 5; j < input.Length; j++)
                            {
                                if (input[j] == '\"')
                                {
                                    for (int k = j + 1; k < input.Length; k++)
                                    {
                                        if (input[k] == '\"')
                                        {
                                            index = k + 1;
                                            break;
                                        }
                                        oldContent += input[k];
                                    }
                                    break;
                                }
                            }
                            repeat = int.Parse(oldContent);
                            oldContent = null;
                            for (int j = index; j < input.Length; j++)
                            {
                                if (input[j] == '\"')
                                {
                                    for (int k = j + 1; k < input.Length; k++)
                                    {
                                        if (input[k] == '\"')
                                        {
                                            break;
                                        }
                                        oldContent += input[k];
                                    }
                                    break;
                                }
                            }
                            for (int j = 0; j < repeat; j++)
                            {
                                Console.WriteLine("{0}. {1}", count, oldContent);
                                count++;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
                
                input = Console.ReadLine();
                oldContent = null;
                newContent = null;
            }
        }
    }
}
