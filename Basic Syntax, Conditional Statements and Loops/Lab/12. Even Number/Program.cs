using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int someNum = int.Parse(Console.ReadLine());
            while (someNum %2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                someNum =int.Parse(Console.ReadLine());
            }
            someNum = Math.Abs(someNum);
            Console.WriteLine($"The number is: {someNum}");
        }
    }
}
