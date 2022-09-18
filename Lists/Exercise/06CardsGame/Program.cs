using System;
using System.Collections.Generic;
using System.Linq;

namespace _06CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> First = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> Second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (First.Count > 0 || Second.Count > 0)
            {
                if (First[0] > Second[0])
                {
                    First.Add(First[0]);
                    First.Add(Second[0]);
                }
                else if (First[0] < Second[0])
                {
                    Second.Add(Second[0]);
                    Second.Add(First[0]);
                }

                First.Remove(First[0]);
                Second.Remove(Second[0]);

                if (First.Count == 0)
                {
                    int result = Second.Sum();
                    Console.WriteLine($"Second player wins! Sum: {result}");
                    break;
                }

                if (Second.Count == 0)
                {
                    int result = First.Sum();
                    Console.WriteLine($"First player wins! Sum: {result}");
                    break;
                }
            }
        }
    }
}

