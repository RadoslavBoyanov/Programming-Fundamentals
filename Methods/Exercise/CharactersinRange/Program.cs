using System;

namespace CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            PrintTheCharsBetweenTwoChars(firstLine, secondLine);
        }

        //static void ASCI(char start, char end)

        //{
        //    for (int i = start + 1; i < end; i++)
        //    {
        //        Console.Write($"{(char)i} ");
        //    }
        //}

        private static void PrintTheCharsBetweenTwoChars(char firstCharacter, char secondCharacter)
        {
            int startCharacter = Math.Min(firstCharacter, secondCharacter);
            int endCharacter = Math.Max(firstCharacter, secondCharacter);

            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}
