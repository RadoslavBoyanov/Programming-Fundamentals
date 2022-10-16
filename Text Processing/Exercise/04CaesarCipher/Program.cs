using System;
using System.Text;
using System.Transactions;

namespace _04CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char [] chars = input.ToCharArray();
            string result = "";

            foreach (char singleChar in chars)
            {
                char tempChar = (char)((char)singleChar + 3);
                result += tempChar;
            }
            Console.WriteLine(result);
        }
    }
}
