using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tripleLatinLetters = int.Parse(Console.ReadLine());

            for (int i = 0; i < tripleLatinLetters; i++)
            {
                for (int j = 0; j < tripleLatinLetters; j++)
                {
                    for (int k = 0; k < tripleLatinLetters; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
