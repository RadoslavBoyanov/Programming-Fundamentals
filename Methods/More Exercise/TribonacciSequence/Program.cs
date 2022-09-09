using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Tribonacci(inputNumber);
        }

        private static void Tribonacci(int inputNumber)
        {
            if (inputNumber < 1)
            {
                return;
            }

            int a = 1;
            int b = 1;
            int c = 2;

            Console.Write(a + " ");
            
            if (inputNumber > 1)
                Console.Write(b + " ");

            if (inputNumber > 2)
                Console.Write(c + " ");

            for (int i = 3; i < inputNumber; i++)
            {
                int curr = a + b + c;
                a = b;
                b = c;
                c = curr;
                Console.Write(curr + " ");
            }
        }
    }
}
