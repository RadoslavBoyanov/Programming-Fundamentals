using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCountOfBeerKegs = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            double volumeOfKeg = 0;
            string thisIsAnswer = string.Empty;

            for (int i = 0; i < totalCountOfBeerKegs; i++)
            { 
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                volumeOfKeg = Math.PI * (radiusOfKeg * radiusOfKeg) * heightOfKeg;

                if (volumeOfKeg > biggestKeg)
                {
                    biggestKeg = volumeOfKeg;
                    thisIsAnswer = modelOfKeg;
                }
            }
            Console.WriteLine(thisIsAnswer);
        }
    }
}
