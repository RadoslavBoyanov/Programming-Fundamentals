using System;
using System.Threading.Channels;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            string method = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int secNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            if (method == "add")
            {
                sum = number + secNumber;
            }
            else if (method == "multiply")
            {
                sum = number * secNumber;
            }
            else if (method == "substract")
            {
                sum = number - secNumber;
            }
            else
            {
                sum = number / secNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
