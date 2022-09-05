using System;
using System.Globalization;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] peopleInWagons = new int[numberOfWagons];
            for (int i = 0; i < numberOfWagons; i++)
            {
                int number = int.Parse(Console.ReadLine());
                peopleInWagons[i] = number;
            }

            for (int i = 0; i < peopleInWagons.Length; i++)
            {
                Console.Write(peopleInWagons[i] + " ");
                sum += peopleInWagons[i];
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
