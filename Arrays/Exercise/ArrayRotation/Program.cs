using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] araInts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int temporary = araInts[0];
                for (int j = 0; j < araInts.Length - 1; j++)
                {
                    araInts[j] = araInts[j + 1];
                }
                araInts[araInts.Length - 1] = temporary;
            }

            Console.WriteLine(String.Join(' ',araInts));
        }
    }
}
