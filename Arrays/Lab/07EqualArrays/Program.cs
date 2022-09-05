using System;
using System.Linq;

namespace _07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayInts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArrayInts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool arraysAreIdentical = false;

            for (int i = 0; i < firstArrayInts.Length; i++)
            {
                if (firstArrayInts[i] != secondArrayInts[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreIdentical = false;
                    break;
                }
                if (firstArrayInts[i] == secondArrayInts[i])
                {
                    sum += firstArrayInts[i];
                    arraysAreIdentical = true;
                }
            }

            if (arraysAreIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
           
        }
    }
}
