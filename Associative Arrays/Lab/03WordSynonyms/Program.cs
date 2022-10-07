using System;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                var word = Console.ReadLine();
                var synonim = Console.ReadLine();

                if (wordSynonyms.ContainsKey(word) == false)
                {
                    wordSynonyms.Add(word, new List<string>());
                }
                wordSynonyms[word].Add(synonim);
            }

            foreach (var word in wordSynonyms)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
