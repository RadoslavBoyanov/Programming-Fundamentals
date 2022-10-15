using System;
using System.Linq;

namespace _01ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reverseWord = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseWord += input[i];
                }
                Console.WriteLine($"{input} = {reverseWord}");
                input = Console.ReadLine();
            }
        }
    }
}
