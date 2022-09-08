using System;
using System.Diagnostics.CodeAnalysis;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string product = Console.ReadLine();    
            //int quantity = int.Parse(Console.ReadLine());

            CalculatingPrice( Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void CalculatingPrice(string product, int quantity)
        {
            decimal coffe = (decimal)1.50;
            decimal water = (decimal)1;
            decimal coke = (decimal)1.40;
            decimal snacks = (decimal)2;
            decimal sum = 0;
            switch (product)
            {
                case "coffee":
                    sum = (decimal)(quantity * 1.50);
                    break;
                case "water":
                    sum = quantity * 1;
                    break;
                case "coke":
                    sum = (decimal)(quantity * 1.40);
                    break;
                case "snacks":
                    sum = quantity * 2; 
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
