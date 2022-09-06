using System;
using System.Linq;

namespace MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int evenSum = GetEvenDigits(number);
            int oddSum = GetOddDigits(number);
            int result = Output(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetEvenDigits(int number)
        {
            int evenSum = 0;
            int evenDigit = 0;
            while (number > 0)
            {
                evenDigit = number % 10;
                if (evenDigit % 2 == 0)
                {
                    evenSum += evenDigit;
                }
                number =number / 10;
            }

            return evenSum;
        }

        static int GetOddDigits(int number)
        {
            int oddSum = 0;
            int oddDigit = 0;
            while (number > 0)
            {
                oddDigit = number % 10;
                if (oddDigit % 2 != 0)
                {
                    oddSum += oddDigit;
                }
                number = number / 10;
            }

            return oddSum;
        }

        static int Output(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
