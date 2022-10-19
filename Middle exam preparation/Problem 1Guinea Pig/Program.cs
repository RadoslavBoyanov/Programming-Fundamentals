using System;
using System.Runtime.ExceptionServices;

namespace Problem_1Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityOfFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityOfHay = double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaWeight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                quantityOfFood -= 300;

                if (i % 2 == 0)
                {
                    quantityOfHay -= quantityOfFood * 0.05;
                }

                if (i % 3 == 0)
                {
                    quantityCover -= guineaWeight / 3;
                }

                if (quantityOfFood <= 0 || quantityOfHay <= 0 || quantityCover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(quantityOfFood / 1000):f2}, Hay: {(quantityOfHay / 1000):f2}, Cover: {(quantityCover / 1000):f2}.");
        }
    }
}
