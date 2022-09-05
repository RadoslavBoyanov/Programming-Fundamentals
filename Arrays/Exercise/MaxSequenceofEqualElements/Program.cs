using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int left = 0;
            int right = 0;
            int equalEl = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        equalEl = array[i];
                        Console.Write($"{array[i]} ");
                    }
                }
            }
        }
    }
}
