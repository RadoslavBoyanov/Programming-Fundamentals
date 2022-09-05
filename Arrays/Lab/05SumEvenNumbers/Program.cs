using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(String.Empty).Select(int.Parse).ToArray();
            int evenSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2  == 0)
                {
                    evenSum += number;
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}
