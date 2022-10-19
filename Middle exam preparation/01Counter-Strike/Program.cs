using System;

namespace _01Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int counterWin = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);
               

                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterWin} won battles and {initialEnergy} energy");

                    return;
                }
                counterWin++;
                initialEnergy -= distance;

                if (counterWin % 3 == 0)
                {
                    initialEnergy += counterWin;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {counterWin}. Energy left: {initialEnergy}");
        }
    }
}