using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            int lenght = numbersList.Count;
            for (int i = 0; i < lenght; i++)
            {
                if (numbersList[i] >= 0)
                {
                    newList.Add(numbersList[i]);
                }
            }

            newList.Reverse();
            if (newList.Count >= 1)
            {
                Console.WriteLine(string.Join(' ', newList));
            }
            else Console.WriteLine("empty");
           
        }
    }
}
