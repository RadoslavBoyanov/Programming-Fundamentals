﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PositiveNegativeZero();
        }

        static void PositiveNegativeZero()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
