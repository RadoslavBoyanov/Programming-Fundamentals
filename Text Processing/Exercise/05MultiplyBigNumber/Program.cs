using System;
using System.Numerics;

namespace _05MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            BigInteger result = firstNum * secNum;

            Console.WriteLine(result.ToString());
        }
    }
}
