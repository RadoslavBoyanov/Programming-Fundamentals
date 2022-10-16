using System;
using System.Text;

namespace _06ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            string output = "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                }
            }

            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
