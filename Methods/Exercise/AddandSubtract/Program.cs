using System;
using System.Runtime.ExceptionServices;

namespace AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int output = Adding(firstNum, secondNum ,thirdNum);
            Console.WriteLine(output);

        }

        static int Adding(int first, int sec, int third)
        {
            return first + sec - third;
        }
    }
}
