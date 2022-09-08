using System;

namespace Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            
            int output = Calculate(firstNumber, operators, secondNumber);
            Console.WriteLine(output);
        }

        static int Calculate(int firstNumber, string @operators, int secondNumber)
        {
            double result = 0;
            switch (@operators)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            return (int)result;
        }
    }
}
