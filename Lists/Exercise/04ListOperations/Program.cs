using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int length = list.Count;
            while (command != "End")
            {
                string[] tokens = command.Split(" ");

                
                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    list.Add(numberToAdd);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > list.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.Insert(index, number);
                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > list.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                       continue;
                    }
                    list.RemoveAt(index);
                }
                else if (tokens[0] == "Shift")
                {
                    if (tokens[1] == "left")
                    {
                        int moveToLeft = int.Parse(tokens[2]);
                        ShiftLeft(list, moveToLeft);
                    }
                    else if (tokens[1] == "right")
                    {
                        int moveToRight = int.Parse(tokens[2]);
                        ShiftRight(list, moveToRight);
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static void ShiftRight(List<int> list, int moveToRight)
        {
            for (int i = 0; i < moveToRight; i++)
            {
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> list, int moveToLeft)
        {

            for (int i = 0; i < moveToLeft; i++)
            {
                list.Add(list[0]);
                list.RemoveAt(0);
            }
        }
    }
}
