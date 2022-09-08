using System;
using System.Net;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        private static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (DivisibleByEight(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        private static bool DivisibleByEight(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
