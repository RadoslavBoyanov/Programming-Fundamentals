using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] numDoubles = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numDoubles[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < numDoubles.Length; i++)
            {
                Console.WriteLine($"{numDoubles[i]} => {(int)Math.Round(numDoubles[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
