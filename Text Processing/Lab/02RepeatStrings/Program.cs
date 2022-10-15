using System;
using System.Linq;
using System.Text;

namespace _02RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] someString = Console.ReadLine().Split(" ").ToArray();
           

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var word in someString)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(word);
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
