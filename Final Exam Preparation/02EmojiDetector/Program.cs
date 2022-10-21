using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*{2}|:{2})(?<emojis>[A-Z][a-z]{2,})\1";
            string numbersPattern = @"\d";

            string pieceOfString = Console.ReadLine();

            long threshold = 1;
            MatchCollection numberCollection = Regex.Matches(pieceOfString, numbersPattern);
            MatchCollection match = Regex.Matches(pieceOfString, pattern);

            foreach (Match number in numberCollection)
            {
                threshold *= int.Parse(number.Value);
            }
            
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{match.Count} emojis found in the text. The cool ones are:");

            foreach (Match m in match)
            {
                string emoji = m.Groups["emojis"].Value;
                long coolnes = emoji.ToCharArray().Sum(c => c);

                if (coolnes >= threshold)
                {
                    Console.WriteLine($"{m.Value}");
                }
            }
        }
    }
}
