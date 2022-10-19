using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] tokens = comand.Split(' ');
                string action = tokens[0];

                switch (action)
                {
                    case "swap":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);
                        SlapList(firstIndex, secondIndex, list);
                        break;
                    case "multiply":
                        int firstElement = int.Parse(tokens[1]);
                        int secondElement = int.Parse(tokens[2]);
                        MakeMultiply(firstElement, secondElement, list);
                        break;
                    case "decrease":
                        DecraseAll(list);
                        break;
                }


                comand = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", list));
        }

        private static void DecraseAll(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] - 1;
            }
        }

        private static void MakeMultiply(int firstElement, int secondElement, List<int> list)
        {
            list[firstElement] *= list[secondElement];
        }

        private static void SlapList(int firstIndex, int secondIndex, List<int> list)
        {
            (list[firstIndex], list[secondIndex]) = (list[secondIndex], list[firstIndex]);
        }
    }
}
