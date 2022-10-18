using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _04StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"\@(?<planetName>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<action>[A,D])![^@\-!:>]*->(?<soldierCount>[\d]+)";

            int numberOfCommands = int.Parse(Console.ReadLine());

            var attacked = new List<string>();
            var destroyed = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string commandLine = Console.ReadLine();
                int key = commandLine.ToLower().Count(x => x == 's' || x == 'a' || x == 't' || x == 'r');
                string decryptedMessage = "";

                foreach (var symbol in commandLine)
                {
                    decryptedMessage += (char)(symbol - key);
                }

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    string namePlanet = match.Groups["planetName"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string action = match.Groups["action"].Value;
                    int soldiers = int.Parse(match.Groups["soldierCount"].Value);

                    if (action == "D")
                    {
                        destroyed.Add(namePlanet);
                    }
                    else if (action == "A")
                    {
                        attacked.Add(namePlanet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));

        }
    }
}
