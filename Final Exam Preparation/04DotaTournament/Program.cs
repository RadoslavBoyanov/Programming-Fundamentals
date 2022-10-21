using System;
using System.Collections.Generic;

namespace _04DotaTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var team = new Dictionary<string, List<string>>();
            var teamWins = new Dictionary<string, int>();

            while (command != "Tournament end")
            {
                string[] tokens = command.Split(" -> ");
                string operation = tokens[0];
                string teamName = tokens[1];

                switch (operation)
                {
                    case "New team":
                    {
                        string playerNames = tokens[2];
                        if (!team.ContainsKey(teamName))
                        {
                            team.Add(teamName, new List<string>());
                                team[teamName].Add(playerNames);
                            teamWins.Add(teamName, 0);
                        }
                        break;
                    }
                    case "Disqualification":
                    {
                        if (team.ContainsKey(teamName))
                        {
                            team.Remove(teamName);
                        }

                        if (teamWins.ContainsKey(teamName))
                        {
                            teamWins.Remove(teamName);
                        }
                        break;
                    }
                    case "Win":
                    {
                        if (teamWins.ContainsKey(teamName))
                        {
                            teamWins[teamName] += 1;
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            var forPrint = new Dictionary<string, KeyValuePair<string, int>>();
            forPrint = team + teamWins.Values.ToString();

            foreach (var t in team)
            {
                
            }

        }
    }
}
