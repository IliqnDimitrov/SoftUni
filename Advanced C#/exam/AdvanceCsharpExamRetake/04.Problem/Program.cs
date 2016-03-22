using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int team1 = 0;
            int team2 = 0;
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
            Dictionary<string, int> Wins = new Dictionary<string, int>();
            while (input != "stop")
            {
                string[] elements = input.Split('|');
                string homeTeam = elements[0].Trim();
                string awayTeam = elements[1].Trim();
                string homeScore = elements[2].Trim();
                string awayScore = elements[3].Trim();
                if (database.ContainsKey(homeTeam))
                {
                    database[homeTeam].Add(awayTeam);
                }
                else
                {
                    database.Add(homeTeam, new List<string>());
                    database[homeTeam].Add(awayTeam);
                    Wins.Add(homeTeam, 0);
                }
                if (database.ContainsKey(awayTeam))
                {
                    database[awayTeam].Add(homeTeam);
                }
                else
                {
                    database.Add(awayTeam, new List<string>());
                    database[awayTeam].Add(homeTeam);
                    Wins.Add(awayTeam, 0);
                }
                string[] h = homeScore.Split(':');
                team1 += Convert.ToInt32(h[0]);
                team2 += Convert.ToInt32(h[1]);
                string[] a = awayScore.Split(':');
                team2 += Convert.ToInt32(a[0]);
                team1 += Convert.ToInt32(a[1]);
                if (team1 == team2)
                {
                    int team1FirstScore = Convert.ToInt32(h[0]);
                    int team2FirstScore = Convert.ToInt32(h[1]);
                    int team1SecondScore = Convert.ToInt32(a[1]);
                    int team2SecondScore = Convert.ToInt32(a[0]);
                    if (team2FirstScore < team1SecondScore)
                    {
                        Wins[homeTeam] += 1;
                    }
                    else if (team2FirstScore > team1SecondScore)
                    {
                        Wins[awayTeam] += 1;
                    }

                }
                else if (team1 > team2)
                {
                    Wins[homeTeam] += 1;
                }
                else
                {
                    Wins[awayTeam] += 1;
                }
                team1 = 0;
                team2 = 0;
                input = Console.ReadLine();
            }
            foreach (var team in Wins.OrderByDescending(k => k.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine("{0}",team.Key);
                Console.WriteLine("- Wins: {0}",team.Value);
                Console.WriteLine("- Opponents: {0}", string.Join(", ", database[team.Key].OrderBy(n => n)));
            }
        }
    }
}
