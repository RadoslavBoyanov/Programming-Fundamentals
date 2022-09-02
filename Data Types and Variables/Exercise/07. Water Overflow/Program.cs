using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOflitersWater = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int litersInTank = 0;

            for (int i = 0; i < countOflitersWater; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                
                if (litersInTank + quantitiesOfWater > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    litersInTank += quantitiesOfWater;
                }
                
            }
            if (litersInTank > waterTank)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(litersInTank);
            }
            
        }
    }
}
