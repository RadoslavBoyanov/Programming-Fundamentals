using System;
using System.Collections.Generic;

namespace _05._Students_02
{
    internal class Program
    {
        //Students
        //•	first name
        //•	last name
        //•	age
        //•	home town
        class Students
        {
            public Students
                (string firstName,
                string lastName,
                string age,
                string homeTown)
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

        static void Main(string[] args)
        {
            List<Students> listStudents = new List<Students>();
            string comand = Console.ReadLine();
            while (comand != "end")
            {
                bool conteinsStudent = false;
                string[] infoStudent = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var student in listStudents)
                {
                    if (student.FirstName == infoStudent[0] && student.LastName == infoStudent[1])
                    {
                        conteinsStudent = true;
                        break;
                    }
                }
                if (conteinsStudent)
                {
                    Students studentExis = GetStudents(listStudents, infoStudent);
                    studentExis.FirstName = infoStudent[0];
                    studentExis.LastName = infoStudent[1];
                    studentExis.Age = infoStudent[2];
                    studentExis.HomeTown = infoStudent[3];

                }
                else
                {
                    Students students = new Students(infoStudent[0], infoStudent[1], infoStudent[2], infoStudent[3]);


                    listStudents.Add(students);
                }
                comand = Console.ReadLine();


            }
            string filter = Console.ReadLine();
            List<Students> filterStudent = new List<Students>();

            foreach (var stud in listStudents)
            {

                if (stud.HomeTown == filter)
                {
                    filterStudent.Add(stud);
                }

            }
            foreach (var student in filterStudent)
            {
                //"{firstName} {lastName} is {age} years old."
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }



        }

        private static Students GetStudents(List<Students> listStudents, string[] infoStudent)
        {
            string firstName = infoStudent[0];
            string lastName = infoStudent[1];
            foreach (var student in listStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }

            }
            return null;

        }
    }
}