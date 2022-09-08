using System;
using System.ComponentModel;
using System.Dynamic;

namespace SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int smallest = SmallestInteger(firstInteger, secondInteger, thirdInteger);
            Console.WriteLine(smallest);
        }

        static int SmallestInteger(int first, int second, int third)
        {
            return (first < second) ? (first < third ? first : third) : (second < third ? second : third);
        }
    }
}
