using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentName = Console.ReadLine().Split(" ").ToArray();
                

                var student = new Student(studentName[0], studentName[1], studentName[2]);

                studentsList.Add(student);
            }

            studentsList.OrderByDescending(x => x.Grade).ToList();

            List<Student> sortedStudents = studentsList.OrderByDescending(T => T.Grade).ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, string grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Grade { get; set; }


        }
    }
}
