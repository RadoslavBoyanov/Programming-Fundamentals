using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine()); 
            double thirdNumber = double.Parse(Console.ReadLine());


            if (firstNumber >= secondNumber && firstNumber >= thirdNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine($"{firstNumber}\n{secondNumber}\n{thirdNumber}");
            }
            else if (firstNumber >= secondNumber && firstNumber >= thirdNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine($"{firstNumber}\n{thirdNumber}\n{secondNumber}");
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine($"{secondNumber}\n{firstNumber}\n{thirdNumber}");
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && thirdNumber >= firstNumber)
            {
                Console.WriteLine($"{secondNumber}\n{thirdNumber}\n{firstNumber}");
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && firstNumber >= secondNumber)
            {
                Console.WriteLine($"{thirdNumber}\n{firstNumber}\n{secondNumber}");
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && secondNumber >= firstNumber)
            {
                Console.WriteLine($"{thirdNumber}\n{secondNumber}\n{firstNumber}");
            }



        }
    }
}
