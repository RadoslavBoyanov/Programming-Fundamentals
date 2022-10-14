using System;
using System.Collections.Generic;

namespace _05Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> coursesDictionary = new Dictionary<string, string>();

            Dictionary<string, int> numberOfCoursesDictionary = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] productData = input.Split(" : ");
                string courseName = productData[0];
                string studentName = productData[1];

                if (!numberOfCoursesDictionary.ContainsKey(courseName))
                {
                    numberOfCoursesDictionary.Add(courseName, 1);
                }
                else if (numberOfCoursesDictionary.ContainsKey(courseName))
                {
                    numberOfCoursesDictionary[courseName] += 1;
                }

                if (!coursesDictionary.ContainsKey(studentName))
                {
                    coursesDictionary.Add(studentName, courseName);
                }
                
                input = Console.ReadLine();
            }

            foreach (var number in numberOfCoursesDictionary)
            {
                Console.WriteLine($"{number.Key}: {number.Value}");
                foreach (var course in coursesDictionary)
                {
                    if (number.Key == course.Value)
                    {
                        Console.WriteLine($"-- {course.Key}");
                    }
                }
            }
        }
    }
}
