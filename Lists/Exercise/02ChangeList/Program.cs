using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _02ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens.Length == 2)
                {
                    int removeNumber = int.Parse(tokens[1]);

                    listOfIntegers.RemoveAll(integer => integer == removeNumber);

                }
                else if (tokens.Length == 3)
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    listOfIntegers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', listOfIntegers));
      
    }
}
}
