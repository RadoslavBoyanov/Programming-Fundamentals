using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwordAndContest = new Dictionary<string, string>();

            string input = input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] tokens = input.Split(":");
                string contest = tokens[0];
                string password = tokens[1];

                passwordAndContest.Add(contest, password);

                input = Console.ReadLine();
            }
            var userInContestsPoints = new SortedDictionary<string, Dictionary<string, int>>();
            var userTotalPoints = new Dictionary<string, int>();
           
            string newInput = Console.ReadLine();
            while (newInput != "end of submissions")
            {
                string[] tokens = newInput.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!passwordAndContest.ContainsKey(contest) || !passwordAndContest.ContainsValue(password))
                {
                    newInput = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (!userInContestsPoints.ContainsKey(userName))
                    {
                        userInContestsPoints[userName] = new Dictionary<string, int>();
                        userInContestsPoints[userName].Add(contest, points);
                        userTotalPoints.Add(userName, points);
                    }
                    else
                    {
                        if (userInContestsPoints[userName].ContainsKey(contest))
                        {
                            if (userInContestsPoints[userName][contest] < points)
                            {
                                userInContestsPoints[userName][contest] = points;
                                userTotalPoints[userName] += points;
                            }
                        }
                        else if (!userInContestsPoints[userName].ContainsKey(contest))
                        {
                            userInContestsPoints[userName].Add(contest, points);
                            userTotalPoints[userName] += points;
                        }
                    }
                }

                newInput = Console.ReadLine();
            }

            string bestCandidate = " ";
            int bestScore = int.MinValue;

            foreach (var points in userTotalPoints)
            {
                if (points.Value > bestScore)
                {
                    bestScore = points.Value;
                    bestCandidate = points.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestScore} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in userInContestsPoints)
            {
                Console.WriteLine($"{user.Key}");
                foreach (var userValue in user.Value.OrderByDescending(xi => xi.Value))
                {
                    Console.WriteLine($"#  {userValue.Key} -> {userValue.Value}");
                }
            }
        }
    }
}
