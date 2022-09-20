using System;
using System.Collections.Generic;

namespace _04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');
                if (input == "end")
                {
                    break;
                }
                Student student = new Student(tokens[0], tokens[1], tokens[2], tokens[3]);

                studentList.Add(student);
            }

            string cityName = Console.ReadLine();

            foreach (Student student in studentList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, string age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
