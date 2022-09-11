using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();
            int min = Math.Max(firstList.Count, secondList.Count);
            int maxLenght = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < maxLenght; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            for (int i = maxLenght; i < min; i++)
            {
                if (firstList.Count>secondList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                else
                {
                    resultList.Add(secondList[i]);
                }
                
            }

            Console.WriteLine(String.Join(' ', resultList));
        }
    }
}
