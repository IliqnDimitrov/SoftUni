using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> database = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(';').ToArray();

            if (input[0] == "END")
            {
                break;
            }
            
            if (database.ContainsKey(input[0]))
            {
                if (database[input[0]].ContainsKey(input[1]))
                {
                    database[input[0]][input[1]].Add(input[2]);
                }
                else
                {
                    database[input[0]].Add(input[1], new SortedSet<string>());
                    database[input[0]][input[1]].Add(input[2]);
                }               
            }
            else
            {
                database.Add(input[0], new SortedDictionary<string, SortedSet<string>>());
                database[input[0]].Add(input[1], new SortedSet<string>());
                database[input[0]][input[1]].Add(input[2]);
            }       
        }

        Console.WriteLine();
        foreach (var city in database)
        {
            Console.WriteLine("{0}",city.Key);
            foreach (var club in city.Value)
            {
                Console.WriteLine("->{0}: {1}",club.Key,string.Join(", ",club.Value));
                
            }
        }
    }
}
