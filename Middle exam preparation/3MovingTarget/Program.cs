using System;
using System.Collections.Generic;
using System.Linq;

namespace _3MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] tokens = comand.Split(' ');

                string action = tokens[0];

                switch (action)
                {
                    case "Shoot":
                        int index = int.Parse(tokens[1]);
                        int power = int.Parse(tokens[2]);
                        GetShoot(index, power, list);
                        break;
                    case "Add":
                        int insert = int.Parse(tokens[1]);
                        int value = int.Parse(tokens[2]);
                        MakeAdd(insert, value, list);
                        break;
                    case "Strike":
                        int target = int.Parse(tokens[1]);
                        int radius = int.Parse(tokens[2]);
                        MakeAStrike(target, radius, list);
                        break;
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine(String.Join("|", list));
        }

        private static void MakeAStrike(int target, int radius, List<int> list)
        {
            if (target - radius < 0 || target + radius > list.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;
                
            }

            list.RemoveRange(target - radius, radius * 2 + 1);
            
        }

        private static void MakeAdd(int insert, int value, List<int> list)
        {
            if (insert < 0 || insert > list.Count - 1)
            {
                Console.WriteLine("Invalid placement!");
                return;
            }

            list.Insert(insert, value);
        }

        private static void GetShoot(int index, int power, List<int> list)
        {
            if (index < 0 || index > list.Count - 1)
            {
               return;
            }

            list[index] -= power;

            if (list[index] == 0 || list[index] < 0)
            {
                list.RemoveAt(index);
            }
        }
    }
}
