using System;
using System.Linq;

namespace _03ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pathToAFile = Console.ReadLine().Split('\\').ToArray();

            string[] extractFile = pathToAFile.Last().Split('.');

            string fileName = extractFile[0];
            string extension = extractFile[1];

            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");

        }
    }
}
