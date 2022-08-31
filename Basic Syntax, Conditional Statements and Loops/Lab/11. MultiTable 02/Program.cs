using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = int.Parse(Console.ReadLine());
            int secInteger = int.Parse(Console.ReadLine());
            int product = 0;

            for (int times = secInteger; times <= 10 ; times++)
            {
                product = integer * times;
                Console.WriteLine($"{integer} X {times} = {product}");
            }

            if (secInteger > 10)
            {
                product = integer * secInteger;
                Console.WriteLine($"{integer} X {secInteger} = {product}");
            }

        }
    }
}
