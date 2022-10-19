using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;

namespace _02FriendListMaintenanceMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernamesList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int blackListedNames = 0;
            int numberOfLostNames = 0;

            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];
                switch (command)
                {
                    case "Blacklist":
                        string name = tokens[1];

                        if (usernamesList.Contains(name))
                        {
                            blackListedNames++;
                            Console.WriteLine($"{name} was blacklisted.");
                            int indexOfName = usernamesList.IndexOf(name);
                            usernamesList.Remove(name);
                            usernamesList.Insert(indexOfName, "Blacklisted");
                        }
                        else
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;
                    case "Error":
                        int index = int.Parse(tokens[1]);
                        string names = usernamesList[index];

                        if (index < 0 && index > usernamesList.Count - 1 || names == "Blacklisted" || names == "Lost")
                        {
                            break;
                        }
                        else
                        {
                            numberOfLostNames++;
                            Console.WriteLine($"{names} was lost due to an error.");
                            usernamesList.RemoveAt(index);
                            usernamesList.Insert(index, "Lost");
                        }
                        break;
                    case "Change":
                        int atIndex = int.Parse(tokens[1]);
                        string newName = tokens[2];
                        ChangeTheName(atIndex, newName, usernamesList);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blackListedNames}");
            Console.WriteLine($"Lost names: {numberOfLostNames}");
            Console.WriteLine(String.Join(" ", usernamesList));
        }

        private static void ChangeTheName(int atIndex, string newName, List<string> usernamesList)
        {
            if (atIndex >= 0 && atIndex <= usernamesList.Count - 1)
            {
                string name = usernamesList[atIndex];
                usernamesList.Insert(atIndex + 1, newName);
                usernamesList.RemoveAt(atIndex);

                Console.WriteLine($"{name} changed his username to {newName}.");
            }
        }
    }
}

