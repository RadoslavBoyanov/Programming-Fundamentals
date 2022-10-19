using System;

namespace _01BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxAttendances = Double.MinValue;
            double maxBonus = Double.MinValue;
            double tottalBonus = 0;

            if (numberOfStudents == 0 || lecturesCount == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");

                return;
            }

            for (int i = 1; i <= numberOfStudents; i++)
            {
                double studentAttendances = int.Parse(Console.ReadLine());

                tottalBonus = studentAttendances / lecturesCount * (5 + additionalBonus);

                if (tottalBonus >= maxBonus)
                {
                    maxBonus = tottalBonus;
                    maxAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
