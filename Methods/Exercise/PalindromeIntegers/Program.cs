using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PalindromeIntegers(input);
        }

        private static void PalindromeIntegers(string input)
        {
            while (input != "END")
            {
                string reverse = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i].ToString();
                }

                if (input == reverse)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
