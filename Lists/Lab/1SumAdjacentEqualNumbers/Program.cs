using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _1SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numberDoubles = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numberDoubles.Count - 1; i++)
            {
                if (numberDoubles[i] == numberDoubles[i + 1])
                {
                    numberDoubles[i] += numberDoubles[i + 1];
                    numberDoubles.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numberDoubles));
        }
    }
}
