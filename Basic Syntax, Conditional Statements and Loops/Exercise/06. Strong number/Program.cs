using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int integerCopy = integer;
            int sum = 0;

            while (integer > 0)
            {
                int factorialNumber = 1;
                int currNumber = integer % 10;
                integer /= 10;

                for (int i = 2; i <= currNumber; i++)
                {
                    factorialNumber *= i;
                }
                sum += factorialNumber;
            }
            Console.WriteLine(sum == integerCopy ? "yes" : "no");
        }
    }
}
