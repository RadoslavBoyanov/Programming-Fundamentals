using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4Santa_sSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            string patternName = "@([A-Za-z]+)[^@\\-!:>]*!([G])!";
            string decryption = string.Empty;

            while (input != "end")
            {
                decryption = string.Empty;
                foreach (var ch in input)
                {
                    decryption += (char)(ch - key);
                }

                Match match = Regex.Match(decryption, patternName);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }
        }
    }
}
