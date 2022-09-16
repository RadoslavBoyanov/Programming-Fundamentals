using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string> listOfNames = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string whatIsGoing = Console.ReadLine();
                string[] whatNames = whatIsGoing.Split(" ");
                string currName = whatNames[0];

                if (whatNames[2] == "going!")
                {
                    if (listOfNames.Contains(currName))
                    {
                        Console.WriteLine($"{currName} is already in the list!");
                    }
                    else
                    {
                        listOfNames.Add(whatNames[0]);
                    }
                }

                if (whatNames[2] == "not")
                {
                    if (!listOfNames.Contains(currName))
                    {
                        Console.WriteLine($"{currName} is not in the list!");
                    }
                    else
                    {
                        listOfNames.Remove(whatNames[0]);
                    }
                }
            }

            foreach (string name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
