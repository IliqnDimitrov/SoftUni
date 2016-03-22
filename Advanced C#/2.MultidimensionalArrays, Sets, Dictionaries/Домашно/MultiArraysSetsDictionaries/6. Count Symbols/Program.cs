using System;
using System.Collections.Generic;
using System.Linq;

class LettersCount
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<char,int> countSymbools = new Dictionary<char, int>();

        int val = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (countSymbools.ContainsKey(input[i]))
            {
                countSymbools.TryGetValue(input[i], out val);

                countSymbools[input[i]] = val + 1;
            }
            else
            {
                countSymbools.Add(input[i], 1);
            }
        }

        var keyValuePairs = countSymbools.OrderBy(c => c.Key).ThenBy(ch => char.IsUpper(ch.Key));

        foreach (var item in keyValuePairs)
        {
            Console.WriteLine("{0}: {1} time/s",item.Key,item.Value);
        }
    }
}

