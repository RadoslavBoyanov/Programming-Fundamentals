using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            string pattern = @"\b(?<day>[0-9]{2})([./\-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(date);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");   
            }
        }
    }
}
