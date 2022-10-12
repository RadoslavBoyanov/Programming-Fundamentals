using System;
using System.Collections.Generic;
using System.Linq;

namespace _1CountCharsinaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsList = Console.ReadLine().Split(" ").ToList();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            for (int i = 0; i < wordsList.Count; i++)
            {
                string currentWord = wordsList[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    char charecter = currentWord[j];
                    if (occurrences.ContainsKey(charecter.ToString()))
                    {
                        occurrences[charecter.ToString()]++;
                    }
                    else
                    {
                        occurrences.Add(charecter.ToString(), 1);
                    }
                }
            }

            foreach (var wordOccurrence in occurrences)
            {
                Console.WriteLine($"{wordOccurrence.Key} -> {wordOccurrence.Value}");
            }
        }
    }
}
