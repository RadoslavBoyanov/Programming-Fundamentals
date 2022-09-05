using System;

namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekDay =int.Parse(Console.ReadLine());
            string[] daysOfWeak =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };


            if (weekDay >= 1 && weekDay <=7)
            {
                Console.WriteLine(daysOfWeak[weekDay - 1]);    
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
