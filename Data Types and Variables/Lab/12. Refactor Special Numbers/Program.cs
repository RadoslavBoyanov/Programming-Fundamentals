using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int countInteger = 0;
            bool @true = false;
            for (int integerNumber = 1; integerNumber <= count; integerNumber++)
            {
                countInteger = integerNumber;
                while (integerNumber > 0)
                {
                    totalSum += integerNumber % 10;
                    integerNumber = integerNumber / 10;
                }
                @true = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine("{0} -> {1}", countInteger, @true);
                totalSum = 0;
                integerNumber = countInteger;
            }

        }
    }
}
