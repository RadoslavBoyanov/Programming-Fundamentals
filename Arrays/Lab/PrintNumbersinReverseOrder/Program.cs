using System;

namespace PrintNumbersinReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count =int.Parse(Console.ReadLine());
            
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
