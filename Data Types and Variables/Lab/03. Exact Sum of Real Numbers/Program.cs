using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal exactSum = 0;
            for (int i = 1; i <= count; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());

                exactSum += num;
            }
            Console.WriteLine(exactSum);
        }
    }
}
