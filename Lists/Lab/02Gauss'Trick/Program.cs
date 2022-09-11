using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            //List<int> gausInts = new List<int>();
            int originalLenght = numbers.Count;
            for (int i = 0; i < originalLenght / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            
            //if (originalLenght % 2 != 0)
            //{
            //    numbers.Add(numbers.Count / 2);
            //}

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
