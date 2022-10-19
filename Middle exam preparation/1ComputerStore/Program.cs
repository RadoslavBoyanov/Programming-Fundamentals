using System;

namespace _1ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            double totalPrice = 0;
            double priceWithoutTaxes = 0;
            double amountOfTaxes = 0;
            
            while (input != "special" && input != "regular")
            {
                double prices = double.Parse(input);

                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                }
                else if (prices > 0)
                {
                    
                    priceWithoutTaxes += prices;
                    amountOfTaxes = priceWithoutTaxes * 0.20;
                    totalPrice = priceWithoutTaxes + amountOfTaxes;
                    input = Console.ReadLine();
                }
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");

                return;
            }

            if (input == "special")
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {amountOfTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
