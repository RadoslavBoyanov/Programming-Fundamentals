using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());  
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int powerPoke = pokePower;
            int counterOfPokedTargets = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counterOfPokedTargets++;
                if (powerPoke * 0.5 == pokePower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            
            Console.WriteLine(pokePower);
            Console.WriteLine(counterOfPokedTargets);
        }
    }
}
