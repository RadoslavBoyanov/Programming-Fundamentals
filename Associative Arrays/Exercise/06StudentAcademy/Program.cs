using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace _06StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, double> studentsDictionary = new Dictionary<string, double>();
            Dictionary<string, double> newStudentsDictionary = new Dictionary<string, double>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                int counter = 1;
                string nameOfStudent = Console.ReadLine();
                double gradeOfStudent = double.Parse(Console.ReadLine());

                if (!studentsDictionary.ContainsKey(nameOfStudent))
                {
                    studentsDictionary.Add(nameOfStudent, gradeOfStudent);
                }
                else if (studentsDictionary.ContainsKey(nameOfStudent))
                {
                    counter++;
                    studentsDictionary[nameOfStudent] += gradeOfStudent;
                    studentsDictionary[nameOfStudent] /= counter;
                }

            }

            Dictionary<string, double> newStudentsOrder = new Dictionary<string, double>();

            foreach (var student in studentsDictionary)
            {
                if (student.Value >= 4.50)
                {
                    newStudentsOrder.Add(student.Key, student.Value);
                }   
            }

            foreach (var student in newStudentsOrder)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
