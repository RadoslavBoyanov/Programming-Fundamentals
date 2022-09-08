using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double area = CalculatesArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
           Console.WriteLine(area);
        }

        static double CalculatesArea(double wildth,double height)
        {
            return wildth * height;
        }
    }
}
