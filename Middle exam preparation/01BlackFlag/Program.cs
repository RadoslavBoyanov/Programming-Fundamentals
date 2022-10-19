using System;

namespace _01BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                total += dailyPlunder;

                if (i % 3 == 0)
                {
                    total += dailyPlunder * 0.50;
                }

                if (i % 5 == 0)
                {
                    total *= 0.70;
                }
            }

            if (total >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
            }
            else
            {
                double percentOfExpected = (double)total / (double)expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentOfExpected:f2}% of the plunder.");
            }
        }
    }
}
