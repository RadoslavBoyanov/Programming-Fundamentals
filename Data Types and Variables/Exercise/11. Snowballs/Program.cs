using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger highestSnowballValue = int.MinValue;
            string bestSnowbaallFormula = "";

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(currentSnowballValue, snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    bestSnowbaallFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(bestSnowbaallFormula);
        }
    }
}
