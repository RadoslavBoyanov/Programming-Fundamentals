using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _02Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var contestAndParticipants = new Dictionary<string, Dictionary<string, int>>();
            var numberOfParticipantsInContests = new SortedDictionary<string, int>();
            var individualStatic = new Dictionary<string, int>();

            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string userName = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!numberOfParticipantsInContests.ContainsKey(contest))
                {
                    numberOfParticipantsInContests.Add(contest, 1);
                }
                else
                {
                    numberOfParticipantsInContests[contest]++;
                }

                if (!contestAndParticipants.ContainsKey(userName))
                {
                    contestAndParticipants[userName] = new Dictionary<string, int>();
                    contestAndParticipants[userName].Add(contest, points);
                }
                else if (contestAndParticipants.ContainsKey(userName) &&
                         contestAndParticipants.ContainsKey(contest))
                {
                    if (contestAndParticipants[userName][contest] < points)
                    {
                        contestAndParticipants[userName][contest] = points;
                    }
                }

                if (!individualStatic.ContainsKey(userName))
                {
                    individualStatic.Add(userName, points);
                }
                else
                {
                    individualStatic[userName] += points;
                }


                input = Console.ReadLine();
            }

             
            foreach (var contest in numberOfParticipantsInContests)
            {
                int counter = 0;
                Console.WriteLine($"{contest.Key}: {contest.Value} participants");
                foreach (var user in contestAndParticipants)
                {
                    
                    foreach (var somePair in user.Value.OrderByDescending(xi => xi.Value))
                    {
                        if (contest.Key == somePair.Key)
                        {
                            counter++;
                            Console.WriteLine($"{counter}. {user.Key} <::> {somePair.Value}");
                        }
                    }
                }
            }

            int counterIndividual = 0;
            Console.WriteLine("Individual standings:");
            foreach (var individual in individualStatic.OrderByDescending(xi => xi.Value))
            {
                counterIndividual++;
                Console.WriteLine($"{counterIndividual}. {individual.Key} -> {individual.Value}");
            }

        }
    }
}
