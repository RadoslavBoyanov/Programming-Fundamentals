using System;

namespace _01ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string operation = Console.ReadLine();

            while (operation != "Generate")
            {
                string[] tokens = operation.Split(">>>");

                string action = tokens[0];

                switch (action)
                {
                    case "Contains":
                    {
                        string substring = tokens[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    }
                    case "Flip":
                    {
                        string upperOrLower = tokens[1];
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        if (upperOrLower == "Upper")
                        { 
                            string substringUpper = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                           activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                           activationKey = activationKey.Insert(startIndex, substringUpper);
                           Console.WriteLine(activationKey);
                        }
                        else
                        {
                            string substringLower = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                            activationKey = activationKey.Insert(startIndex, substringLower);
                            Console.WriteLine(activationKey);
                        }
                        break;
                    }
                    case "Slice":
                    {
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                    }
                }
                operation = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
