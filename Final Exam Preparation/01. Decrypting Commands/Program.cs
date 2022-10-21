using System;
using System.Linq;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string dectrypting = Console.ReadLine();
            while (dectrypting != "Finish")
            {
                string[] command = dectrypting.Split(" ");
                string operation = command[0];
                switch (operation)
                {
                    case "Replace":
                    {
                        string currentChar = command[1];
                        string newChar = command[2];
                        text = text.Replace(currentChar, newChar);
                        Console.WriteLine(text);
                        break;
                    }
                    case "Cut":
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if ((startIndex >= 0 && startIndex <= text.Length - 1) && (endIndex >= 0 && endIndex <= text.Length - 1))
                        {
                            text = text.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    }
                    case "Make":
                    {
                        string upperOrLower = command[1];
                        if (upperOrLower == "Upper")
                        {
                            text = text.ToUpper();
                            Console.WriteLine(text);
                        }
                        else if (upperOrLower == "Lower")
                        {
                            text = text.ToLower();
                            Console.WriteLine(text);
                        }
                        break;
                    }
                    case "Check":
                    {
                        string word = command[1];
                        if (text.Contains(word))
                        {
                            Console.WriteLine($"Message contains {word}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {word}");
                        }
                        break;
                    }
                    case "Sum":
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        string substring = string.Empty;
                        if ((startIndex >= 0 && startIndex <= text.Length - 1) && (endIndex >= 0 && endIndex <= text.Length - 1))
                        { 
                            substring = text.Substring(startIndex, endIndex - startIndex + 1);
                            int asciiSum = 0;
                            for (int i = 0; i < substring.Length; i++)
                            {
                                asciiSum += substring[i];
                            }

                            Console.WriteLine(asciiSum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    }
                }

                dectrypting = Console.ReadLine();  
            }
        }
    }
}
