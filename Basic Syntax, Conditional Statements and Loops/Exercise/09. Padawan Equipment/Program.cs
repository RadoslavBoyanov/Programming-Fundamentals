using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());    
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfSingleSaber = double.Parse(Console.ReadLine());
            double priceOfSingleRobe = double.Parse(Console.ReadLine());
            double priceOfSingleBelt = double.Parse(Console.ReadLine());

            double totalPriceRobe = countOfStudents * priceOfSingleRobe;
            
            double totalLightsabers = Math.Ceiling(countOfStudents * 1.10);
            double totalPriceLightsabers = totalLightsabers * priceOfSingleSaber;

            double freeBelts = countOfStudents / 6;
            double totalPriceBelt = (countOfStudents - freeBelts) * priceOfSingleBelt;

            double totalPrice = totalPriceLightsabers + totalPriceRobe + totalPriceBelt;

            double diff = Math.Abs(amountOfMoney - totalPrice);

            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}
