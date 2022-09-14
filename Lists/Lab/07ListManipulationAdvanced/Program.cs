using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Channels;

namespace _06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool change = false;
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
                    case "Contains":
                        int numberContains = int.Parse(tokens[1]);
                        if (numberList.Contains(numberContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintOdd":
                        OddNumber(numberList);
                        break;
                    case "PrintEven":
                        EvenNumber(numberList);
                        break;
                    case "GetSum":
                        GetSum(numberList);
                        break;
                    case "Filter":
                        string sign = tokens[1]; int numberF = int.Parse(tokens[2]);
                        if (sign == ">")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                if (numberList[i] > numberF)
                                {
                                    nov.Add(numberList[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == "<")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                if (numberList[i] < numberF)
                                {
                                    nov.Add(numberList[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == "<=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                if (numberList[i] <= numberF)
                                {
                                    nov.Add(numberList[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == ">=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                if (numberList[i] >= numberF)
                                {
                                    nov.Add(numberList[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        break;
                }

            }

            if (change == true)
            {
                Console.WriteLine(string.Join(' ', numberList));
            }

        }


        private static void GetSum(List<int> numberList)
        {
            int result = numberList.Sum();
            Console.WriteLine(result);
        }

        private static void OddNumber(List<int> numberList)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    newList.Add(numberList[i]);
                }
            }

            Console.WriteLine(String.Join(' ', newList));
        }

        private static void EvenNumber(List<int> numberList)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    newList.Add(numberList[i]);
                }
            }

            Console.WriteLine(String.Join(' ', newList));
        }
    }
}