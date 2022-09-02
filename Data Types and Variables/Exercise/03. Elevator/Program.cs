using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elevateNPersons = int.Parse(Console.ReadLine());
            int capacityOfPPersons = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double) elevateNPersons / capacityOfPPersons);

            Console.WriteLine(courses);
        }
    }
}
