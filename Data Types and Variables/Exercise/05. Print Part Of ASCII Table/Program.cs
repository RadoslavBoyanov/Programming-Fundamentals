using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startForCicle = int.Parse(Console.ReadLine());
            int endForCicle = int.Parse(Console.ReadLine());

            for (int i = startForCicle; i <= endForCicle; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
