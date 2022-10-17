using System;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[+]359 2 [0-9]{3} [0-9]{4}\b|[+]359-2-[0-9]{3}-[0-9]{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
