using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _07AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrays = Console.ReadLine().Split( '|').Reverse().ToList();

            var numbers = new List<int>();

            foreach (var numberArray in arrays)
            {
                numbers.AddRange(numberArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
