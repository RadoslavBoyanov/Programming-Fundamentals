using System;
using System.Collections.Generic;
using System.Linq;

namespace _02TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine().Split("|").ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];

                switch (command)
                {
                    case "Loot":
                        LootItem(tokens, initialLoot);
                        break;
                    case "Drop":
                        int index = int.Parse(tokens[1]);
                        DropItem(tokens, index, initialLoot);
                        break;
                    case "Steal":
                        int count = int.Parse(tokens[1]);
                        StealItems(count, initialLoot);
                        break;
                }


                input = Console.ReadLine();
            }

            double result = 0;
            foreach (var loot in initialLoot)
            {
                result += loot.Length;
            }

            double total = result / initialLoot.Count;
            if (total > 0)
            {
                Console.WriteLine($"Average treasure gain: {total:f2} pirate credits");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static void StealItems(int count, List<string> initialLoot)
        {
            List<string> removeElements = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                initialLoot.RemoveAt(initialLoot.Count - 1);
                removeElements.Add(initialLoot[i]);
            }
        }

        private static void DropItem(string[] strings, int index, List<string> initialLoot)
        {
            if (index > 0 && index < initialLoot.Count - 1)
            {
                string element = initialLoot[index];
                initialLoot.RemoveAt(index);
                initialLoot.Add(element);
            }
        }

        private static void LootItem(string[] tokens, List<string> initialLoot)
        {
            for (int i = 1; i < tokens.Length; i++)
            {
                if (initialLoot.Contains(tokens[i]))
                {
                    continue;
                }
                else
                {
                    initialLoot.Insert(0, tokens[i]);
                }
            }
        }
    }
}
