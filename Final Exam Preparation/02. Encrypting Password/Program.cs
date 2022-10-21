using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)>(?<number>[\d]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^\<\>]{3})<\1$";

            int numberOfIndicates = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIndicates; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string encrypted = $"{match.Groups["number"].Value}{match.Groups["lower"].Value}{match.Groups["upper"].Value}{match.Groups["symbols"].Value}";
                    Console.WriteLine($"Password: {encrypted}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
