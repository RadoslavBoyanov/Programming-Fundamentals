using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordLine = Console.ReadLine();

            Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

            

            while (wordLine != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourcesQuantity.ContainsKey(wordLine))
                {
                    resourcesQuantity[wordLine] += quantity;
                }
                else
                {
                    resourcesQuantity[wordLine] = quantity;
                }

                wordLine = Console.ReadLine();
            }

            foreach (var item in resourcesQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
