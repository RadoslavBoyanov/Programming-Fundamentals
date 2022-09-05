using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] arraInts = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < arraInts.Length; i++)
            {
                bool isATopInteger = true;
                int currIntNum = arraInts[i];
                for (int j = i + 1; j < arraInts.Length; j++)
                {
                    int nextIntNum = arraInts[j];
                    if (currIntNum <= nextIntNum)
                    {
                        isATopInteger = false;
                        break;
                    }
                }

                if (isATopInteger)
                {
                    Console.Write($"{currIntNum} ");
                }
            }
        }
    }
}
