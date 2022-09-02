using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");

            double height = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");

            double longh = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");
           
            double volume = (lenght * height * longh) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
