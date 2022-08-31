using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int product = 0;

            for (int times = 1; times <= 10; times++)
            {
                product = integer * times;
                Console.WriteLine($"{integer} X {times} = {product}");
            }
        }
    }
}
