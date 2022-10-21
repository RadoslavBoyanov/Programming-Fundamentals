using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:");

                string action = tokens[0];

                switch (action)
                {
                    case "InsertSpace":
                    {
                        int index = int.Parse(tokens[1]);
                        message = message.Insert(index, " ");
                        break;
                    }
                    case "Reverse":
                    {
                        string substring = tokens[1];
                        if (message.Contains(substring))
                        {
                            int index = message.IndexOf(substring);
                            message = message.Remove(index, substring.Length);
                            message = $"{message}{string.Join("", substring.Reverse())}";
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine();
                            continue;
                        }
                        break;
                    }
                    case "ChangeAll":
                    {
                        string substring = tokens[1];
                        string replacement = tokens[2];
                        if (message.Contains(substring))
                        {
                            message = message.Replace(substring, replacement);
                        }
                        break;
                    }
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
