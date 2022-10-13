using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();
            var junkMaterials = new SortedDictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            string winner = string.Empty;
            bool haveWinner = false;

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i = i + 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                    }

                    else if (junkMaterials.ContainsKey(material) == false)
                    {
                        junkMaterials[material] = quantity;
                    }

                    else if (junkMaterials.ContainsKey(material))
                    {
                        junkMaterials[material] += quantity;
                    }

                    if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                    {
                        winner = material;
                        keyMaterials[material] -= 250;
                        haveWinner = true;
                        break;
                    }
                }

                if (haveWinner == true)
                {
                    break;
                }
            }

            if (winner == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
                PrintTheRemainingMaterials(keyMaterials, junkMaterials);
            }

            else if (winner == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
                PrintTheRemainingMaterials(keyMaterials, junkMaterials);
            }

            else
            {
                Console.WriteLine("Dragonwrath obtained!");
                PrintTheRemainingMaterials(keyMaterials, junkMaterials);
            }
        }


        private static void PrintTheRemainingMaterials(Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junkMaterials)
        {
            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}