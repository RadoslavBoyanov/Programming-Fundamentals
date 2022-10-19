using System;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _02ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            int[] lifts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            const int CAPACITYFORONELIFT = 4;

            for (int i = 0; i < lifts.Length; i++)
            {
                for (int j = lifts[i]; j < CAPACITYFORONELIFT; j++)
                {
                    lifts[i]++;
                    maxCapacity--;

                    if (maxCapacity == 0)
                    {
                        if (lifts.Sum() < lifts.Length * maxCapacity)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(' ',lifts));

                        return;
                    }
                }

            }

            Console.WriteLine($"There isn't enough space! {maxCapacity} people in a queue!");
            Console.WriteLine(String.Join(' ', lifts));
        }
    }
}
