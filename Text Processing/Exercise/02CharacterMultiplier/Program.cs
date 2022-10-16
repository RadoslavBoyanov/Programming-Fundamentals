using System;
using System.Reflection.Metadata.Ecma335;

namespace _02CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(Multiplier(input));
            
        }

        public static int Multiplier(string[] input)
        {
            
            var firstString = input[0];
            var secondString = input[1];

            string longest = "";
            string shortest = "";

            if (firstString.Length >= secondString.Length)
            {
                longest = firstString;
                shortest = secondString;
            }
            else if (secondString.Length >= firstString.Length)
            {
                longest = secondString;
                shortest = firstString;
            }

            int result = 0;

            for (int i = 0; i < shortest.Length; i++)
            {
                result += shortest[i] * longest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                result += longest[i];
            }
            return result; 
        }
    }
}
