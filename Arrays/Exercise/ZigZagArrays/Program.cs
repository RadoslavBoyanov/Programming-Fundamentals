using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int[] firstArray = new int[counter];
            int[] secondArray = new int[counter];

            for (int i = 0; i < counter; i++)
            {
                int[] numInts = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = numInts[0];
                    secondArray[i] = numInts[1];
                }
                else
                {
                    firstArray[i] = numInts[1];
                    secondArray[i] = numInts[0];
                }
            }

            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));
        }
    }
}
