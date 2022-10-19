using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            
            int count = 1;
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                
                int[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = tokens[0];
                int secondIndex = tokens[1];


                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex > list.Count - 1 || secondIndex < 0 ||
                    secondIndex > list.Count - 1)
                {
                    list.Insert(list.Count / 2, $"-{count}a");
                    list.Insert(list.Count / 2, $"-{count}a");
                   
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (list[firstIndex] == list[secondIndex])
                {
                    string remover = list[firstIndex];

                    list.Remove(remover);
                    list.Remove(remover);

                    Console.WriteLine($"Congrats! You have found matching elements - {remover}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    
                    return;
                }
                count++;
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', list));
        }
    }
}

