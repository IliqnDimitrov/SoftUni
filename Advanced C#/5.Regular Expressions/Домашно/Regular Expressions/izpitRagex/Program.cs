using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitRagex
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            char[] input2 = Console.ReadLine().ToCharArray();
            Dictionary<string, string> decryptFile = new Dictionary<string, string>()
            {
                {"a","n"},
                {"b","o"},
                {"c","p"},
                {"d","q"},
                {"e","r"},
                {"f","s"},
                {"g","t"},
                {"h","u"},
                {"i","v"},
                {"j","w"},
                {"k","x"},
                {"l","y"},
                {"m","z"},
                {"n","a"},
                {"o","b"},
                {"p","c"},
                {"q","d"},
                {"r","e"},
                {"s","f"},
                {"t","g"},
                {"u","h"},
                {"v","i"},
                {"w","j"},
                {"x","k"},
                {"y","l"},
                {"z","m"},  
            };
            StringBuilder sb = new StringBuilder();
            List<char> text = new List<char>();
            for (int i = 0; i < input2.Length - 3; i++)
            {
                if (input2[i].ToString() == "<" && input2[i + 1].ToString() == "p" && input2[i + 2].ToString() == ">")
                {
                    
                    for (int j = i + 3; j < input2.Length ; j++)
                    {
                        if (input2[j].ToString() == "<" && input2[j + 1].ToString() == "/" && input2[j + 2].ToString() == "p" && input2[j + 3].ToString() == ">")
                        {
                            break;
                        }
                        text.Add(input2[j]);
                    }
             
                    for (int j = 0; j < text.Count; j++)
                    {
                        if (Char.IsLower(text[j]))
                        {
                            sb.Append(text[j]);
                        }
                        else if (Char.IsDigit(text[j]))
                        {
                            sb.Append(text[j]);
                        }
                        else if (!Char.IsLower(text[j]))
                        {
                            sb.Append(' ');
                        }
                    }
                    text.Clear();
                    
                }
            }

            for (int j = 0; j < sb.Length - 1; j++)
            {
                if (sb[j] == ' ')
                {
                    if (sb[j + 1] == ' ')
                    {
                        sb.Remove(j, 1);
                        j--;
                    }
                }
            }
            for (int i = 0; i < sb.Length; i++)
            {
                try
                {
                    sb[i] = Convert.ToChar(decryptFile[sb[i].ToString()]);
                }
                catch (Exception)
                {
                    
                }
            }
            Console.WriteLine(sb);
        }
    }
}
