using System;
using System.Linq;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (string currentElement in firstArray)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    string secondElement = secondArray[i];

                    if (currentElement == secondElement)
                    {
                        Console.Write($"{currentElement} ");
                        break;
                    }
                }
            }
        }
    }
}
