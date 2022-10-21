using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            var validList = new List<string>();
            var mirrorPair = new List<string>();

            if (Regex.IsMatch(text, pattern))
            {
                foreach (Match match in matches)
                {
                    validList.Add(match.ToString());
                }
            }

            for (int i = 0; i < validList.Count; i++)
            {
                string currentWord = validList[i];
                string word = "";
                string reversedWord = "";

                for (int j = 0; j < currentWord.Length / 2; j++)
                {
                    word += currentWord[j];
                }

                for (int k = currentWord.Length - 1; k >= currentWord.Length / 2; k--)
                {
                    reversedWord += currentWord[k];
                }

                if (word == reversedWord)
                {
                    mirrorPair.Add(currentWord);
                }
            }

            if (validList.Count > 0)
            {
                Console.WriteLine($"{validList.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            List<string> final = new List<string>();

            if (mirrorPair.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                string final1 = "";

                foreach (var item in mirrorPair)
                {
                    var curritem = item.Substring(1, (item.Length / 2) - 2);
                    var curritem1 = item.Substring(item.Length / 2 + 1, (item.Length - ((item.Length / 2) + 2)));

                    final1 = $"{curritem} <=> {curritem1}";
                    final.Add(final1);
                }

                Console.WriteLine($"{string.Join(", ", final)}");
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
