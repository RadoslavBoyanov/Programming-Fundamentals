using System;
using System.Runtime.Serialization.Formatters;

namespace expirienceGainingMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            double currentExperience = 0;
            int battleCounter = 0;

            if (neededExperience == 0|| countOfBattles == 0)
            {

                Console.WriteLine($"Player successfully collected his needed experience for {battleCounter} battles.");

                return;
            }

            for (int i = 1; i <= countOfBattles; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                battleCounter++;

                currentExperience += experiencePerBattle;

                if (i % 3 == 0)
                {
                    currentExperience += experiencePerBattle * 0.15;
                }

                if (i % 5 == 0)
                {
                    currentExperience -= experiencePerBattle * 0.10;
                }

                if (i % 15 == 0)
                {
                    currentExperience += experiencePerBattle * 0.05;
                }

                if (currentExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {battleCounter} battles.");

                    return;
                }
            }

            double difference = neededExperience - currentExperience;
            
            Console.WriteLine($"Player was not able to collect the needed experience, {difference:f2} more needed.");
        }
    }
}
