using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char giveAChar = char.Parse(Console.ReadLine());

            if (Char.IsLower(giveAChar))
            {
                Console.WriteLine($"lower-case");
            }
            else
            {
                Console.WriteLine($"upper-case");
            }
            
        }
    }
}
