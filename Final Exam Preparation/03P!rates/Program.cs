using System;
using System.Collections.Generic;

namespace _03P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plunder = new Dictionary<string, List<int>>();

            string[] tokens = Console.ReadLine().Split("||");
            while (tokens[0] != "Sail")
            {
                
                string cities = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (!plunder.ContainsKey(cities))
                {
                    plunder.Add(cities, new List<int>() {population,gold });
                }
                else
                {
                    plunder[cities][0] += population;
                    plunder[cities][1] += gold;
                }
                tokens = Console.ReadLine().Split("||");
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokensCmd = command.Split("=>");
                string action = tokensCmd[0];
                string town = tokensCmd[1];

                switch (action)
                {
                    case "Plunder":
                    {
                        int people = int.Parse(tokensCmd[2]);
                        int gold = int.Parse(tokensCmd[3]);
                            plunder[town][0] -= people;
                            plunder[town][1] -= gold;
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                            if (plunder[town][0] <= 0 || plunder[town][1] <= 0)
                            {
                                plunder.Remove(town);
                                Console.WriteLine($"{town} has been wiped off the map!");
                            }
                        break;
                    }
                    case "Prosper":
                    {
                        int gold = int.Parse(tokensCmd[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            plunder[town][1] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {plunder[town][1]} gold.");
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            if (plunder.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {plunder.Count} wealthy settlements to go to:");

                foreach (var pl in plunder)
                {
                    Console.WriteLine($"{pl.Key} -> Population: {pl.Value[0]} citizens, Gold: {pl.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
}
