using System;
using System.Linq;

namespace _01RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] someText = Console.ReadLine().Split(' ');

            Random random = new Random();

            for (int i = 0; i < someText.Length; i++)
            {
                int newPosition = random.Next(0, someText.Length);

                string currentPosition = someText[i];
                someText[i] = someText[newPosition];
                someText[newPosition]= currentPosition;
            }

            foreach (var word in someText)
            {
                Console.WriteLine(word);
            }
        }
    }
}
