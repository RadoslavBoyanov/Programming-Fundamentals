using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                if (tokens.Length == 2)
                {
                    int newWagonWithPeople = int.Parse(tokens[1]);
                    wagons.Add(newWagonWithPeople);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    FindWagon(wagons, passengers, maxCapacity);
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FindWagon(List<int> wagons, int people, int maxCapac)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currWagon = wagons[i];
                if (currWagon + people <= maxCapac)
                {
                    wagons[i] += people;
                    break;
                }
            }
        }
    }
}
