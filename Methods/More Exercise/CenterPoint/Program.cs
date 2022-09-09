using System;

namespace CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CartesianCoordinate(x1, y1, x2, y2);
        }

        private static void CartesianCoordinate(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Pow((double)x1, 2) + Math.Pow((double)y1, 2);
            double secondPoint = Math.Pow((double)x2, 2) + Math.Pow((double)y2, 2);

            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
