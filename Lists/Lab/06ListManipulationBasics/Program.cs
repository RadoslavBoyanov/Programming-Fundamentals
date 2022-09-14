using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numberList.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numberList.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(tokens[1]);
                        numberList.RemoveAt(numberToRemoveAt);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int numberToInsertAt = int.Parse(tokens[2]);
                        numberList.Insert(numberToInsertAt, numberToInsert);
                        break;
                }
                
            }
            Console.WriteLine(string.Join(" ", numberList));

        }
    }
}
