using System;
using System.Collections.Generic;

namespace _04Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersDictionary = new Dictionary<string, string>();

            int numbersOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfCommand; i++)
            {
                string[] newUser = Console.ReadLine().Split(' ');

                string operation = newUser[0];

                switch (operation)
                {
                    case "register":
                        string name = newUser[1];
                        string plateNumber = newUser[2];
                        if (!usersDictionary.ContainsKey(name))
                        {
                            usersDictionary.Add(name, plateNumber);
                            Console.WriteLine($"{name} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        string user = newUser[1];
                        if (!usersDictionary.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            usersDictionary.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var user in usersDictionary)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");   
            }
        }
    }
}
