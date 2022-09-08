using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theBase = double.Parse(Console.ReadLine());
            double thePower = double.Parse(Console.ReadLine());
            double result = RaiseToPower(theBase, thePower);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double theBase, double thePower)
        {
            double result = Math.Pow(theBase, thePower);
            return result;
        }
    }
}
