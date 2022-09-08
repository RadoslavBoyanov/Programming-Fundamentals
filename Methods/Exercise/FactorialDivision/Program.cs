using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            FactorialDivision(firstInt, secondInt);
        }

        private static void FactorialDivision(int firstInt, int secondInt)
        {
            double firstFactorial = 1;
            for (int i = 1; i <= firstInt; i++)
            {
                firstFactorial *= i;
            }

            double secondFactorial = 1;
            for (int i = 1; i <= secondInt; i++)
            {
                secondFactorial *= i;
            }

            double factorialResult = firstFactorial / secondFactorial;
            Console.WriteLine($"{factorialResult:f2}");
        }
    }
}
