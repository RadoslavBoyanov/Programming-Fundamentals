using System;

namespace _01WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] tokensCmd = command.Split(":");
                string operation = tokensCmd[0];

                switch (operation)
                {
                    case "Add Stop":
                    {
                        int index = int.Parse(tokensCmd[1]);
                        string country = tokensCmd[2];
                        if (index >= 0 && index <= destination.Length - 1)
                        {
                            destination = destination.Insert(index, country);
                        }
                        Console.WriteLine(destination);
                            break;
                    }
                    case "Remove Stop":
                    {
                        int startIndex = int.Parse(tokensCmd[1]);
                        int endIndex = int.Parse(tokensCmd[2]);
                        if (startIndex >= 0 && startIndex <= destination.Length - 1 && endIndex >= 0 && endIndex <= destination.Length - 1)
                        {
                            destination = destination.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(destination);
                            break;
                    }
                    case "Switch":
                    {
                        string oldString = tokensCmd[1];
                        string newString = tokensCmd[2];
                        if (destination.Contains(oldString))
                        {
                            destination = destination.Replace(oldString, newString);
                            
                        }
                        Console.WriteLine(destination);
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");
        }
    }
}
