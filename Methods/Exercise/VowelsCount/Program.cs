using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           Vowels(input);
        }

        static void Vowels(string input)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'U', 'O' };
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    total++;
                }
            }

            Console.WriteLine(total);
        }
    }
}
