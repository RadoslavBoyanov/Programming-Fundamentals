using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int left = i; left > 0 ; left--)
                {
                    int ellposition = left - 1;
                    if (left > 0)
                    {
                        leftSum += array[ellposition];
                    }
                }

                rightSum = 0;

                for (int right = i; right < array.Length; right++)
                {
                    int nextERightllposition = right + 1;
                    if (right < array.Length - 1)
                    {
                        rightSum += array[nextERightllposition];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
