using System;
using System.Collections.Generic;

namespace _03._Hero_Recruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split(' ');
                string operation = tokens[0];
                string heroName = tokens[1];

                switch (operation)
                {
                    case "Enroll":
                    {
                        if (!heroes.ContainsKey(heroName))
                        {
                            heroes.Add(heroName, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;
                    }
                    case "Learn":
                    {
                        string spellName = tokens[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (!heroes[heroName].Contains(spellName))
                            {
                                heroes[heroName].Add(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        break;
                    }
                    case "Unlearn":
                    {
                        string spellName = tokens[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (heroes[heroName].Contains(spellName))
                            {
                                heroes[heroName].Remove(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} doesn't know {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");   
            }
        }
    }
}
