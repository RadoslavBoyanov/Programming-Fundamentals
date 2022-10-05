using System;
using System.Collections.Generic;
using System.Linq;

namespace _1CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            SortedDictionary<double, int> sorted = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (sorted.ContainsKey(number))
                {
                    sorted[number]++;
                }
                else
                {
                    sorted.Add(number, 1);
                }
            }

            foreach (var sort in sorted)
            {
                Console.WriteLine($"{sort.Key} -> {sort.Value}");   
            }
        }
    }
}
