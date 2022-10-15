using System;
using System.Collections.Generic;
using System.Text;

namespace _05DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            List<char> letters = new List<char>();
            List<char> characters = new List<char>();

            for (int i = 0; i < someString.Length; i++)
            {
                if (char.IsDigit(someString[i]))
                {
                    numbers.Append(someString[i]);
                }
                else if (char.IsLetter(someString[i]))
                {
                    letters.Add(someString[i]);
                }
                else
                {
                    characters.Add(someString[i]);
                }
            }

            Console.WriteLine(string.Join("", numbers));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", characters));
        }
    }
}
