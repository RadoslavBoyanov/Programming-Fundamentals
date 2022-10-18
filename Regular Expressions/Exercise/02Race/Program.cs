using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfParticipants = Console.ReadLine().Split(", ").ToList();

            var name = new Dictionary<string, int>();

            Regex patternName = new Regex("(?<name>[A-Za-z])");

            string patternOfDigits = @"(?<digits>\d+)";

            string input = Console.ReadLine();
            int sumOfDigit = 0;

            while (input != "end of race")
            {
                MatchCollection matchedNames = patternName.Matches(input);
                MatchCollection matchedDigits = Regex.Matches(input, patternOfDigits);
                string currentName = string.Join("", matchedNames);
                string currentDigits = string.Join("", matchedDigits);

                sumOfDigit = 0;
                for (int i = 0; i < currentDigits.Length; i++)
                {
                    sumOfDigit += int.Parse(currentDigits[i].ToString());
                }

                if (listOfParticipants.Contains(currentName))
                {
                    if (!name.ContainsKey(currentName))
                    {
                        name.Add(currentName, sumOfDigit);
                    }
                    else
                    {
                        name[currentName] += sumOfDigit;
                    }
                }
                
                input = Console.ReadLine();
            }

            var winners = name.OrderByDescending(x => x.Value).Take(3);
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }
            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }
            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
