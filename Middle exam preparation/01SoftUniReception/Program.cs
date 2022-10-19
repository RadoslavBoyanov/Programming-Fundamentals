using System;
using System.Threading.Channels;

namespace _01SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = ushort.Parse(Console.ReadLine());
            int secondEmployee = ushort.Parse(Console.ReadLine());
            int thirdEmployee = ushort.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            
            short hours = 0;

            while (studentsCount > 0)
            {
                studentsCount -= studentsPerHour;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");


        }
    }
}
