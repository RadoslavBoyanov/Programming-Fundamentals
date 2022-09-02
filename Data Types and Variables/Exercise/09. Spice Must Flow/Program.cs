using System;


namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int YEILD_DROPS = 10;
            const int MINING_CREW_CONSUMES = 26;
            const int MINING_YIELD_AT_LEAST = 100;

            int startingYield = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int counterDays = 0;

            while (startingYield >= MINING_YIELD_AT_LEAST)
            {
                totalConsumed += startingYield - MINING_CREW_CONSUMES;
                counterDays++;
                startingYield -= YEILD_DROPS;
                if (startingYield < MINING_YIELD_AT_LEAST)
                {
                    totalConsumed -= MINING_CREW_CONSUMES;
                }
            }
            
            Console.WriteLine(counterDays);
            Console.WriteLine(totalConsumed);
        }
    }
}
