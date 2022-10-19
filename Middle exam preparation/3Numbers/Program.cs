using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            List<int> result = new List<int>();
 
            double average = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    newList.Add(numbers[i]);
                }
            }

            if (newList.Count == 0)
            {
                Console.WriteLine("No");

                return;
            }

            newList.Sort();
            newList.Reverse();
            if (newList.Count > 5)
            {
                for (int i = 0; i <= 4; i++)
                {
                    result.Add(newList[i]);
                }
                Console.WriteLine(String.Join(' ', result));
            }
            else
            {
                Console.WriteLine(String.Join(' ', newList));
            }
        }
    }
}
