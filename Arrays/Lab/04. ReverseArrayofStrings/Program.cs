using System;

namespace _04._ReverseArrayofStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] charecterStrings = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(charecterStrings);

            Console.WriteLine(string.Join(" ", charecterStrings));
        }
    }
}
