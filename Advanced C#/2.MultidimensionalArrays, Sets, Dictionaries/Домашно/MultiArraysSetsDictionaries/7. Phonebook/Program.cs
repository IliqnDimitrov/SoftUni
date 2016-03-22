using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        Dictionary<string,string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            string[] input = Console.ReadLine().Split('-');
            if (input[0] == "search")
            {
                while (true)
                {
                    string searchContact = Console.ReadLine();
                    if (phoneBook.ContainsKey(searchContact))
                    {
                        Console.WriteLine("{0} -> {1}",searchContact,phoneBook[searchContact]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",searchContact);
                    }
                }
            }
            phoneBook.Add(input[0],input[1]);
        }
    }
}
