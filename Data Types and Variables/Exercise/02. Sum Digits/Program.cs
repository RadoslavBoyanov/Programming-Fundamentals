using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int cutNum = 0;


            while (number > 0)
            {
                cutNum = number % 10;
                sum += cutNum;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
