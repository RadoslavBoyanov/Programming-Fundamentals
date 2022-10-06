using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _02OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in sequence)
            {
                string wordInLower = word.ToLower();
                if (counts.ContainsKey(wordInLower))
                {
                    counts[wordInLower]++;
                }
                else
                {
                    counts.Add(wordInLower, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
