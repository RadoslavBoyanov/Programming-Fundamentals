using System;
using System.Collections.Generic;
using System.Linq;

namespace _07Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<OrderByAge> listOfPersons = new List<OrderByAge>();

            while (input != "End")
            {
                string[] tokens = input.Split(" ").ToArray();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                OrderByAge orderByAge = new OrderByAge(name, id, age);

                if (!listOfPersons.Contains(orderByAge))
                {
                    listOfPersons.Add(orderByAge);
                }
                else if (listOfPersons.Contains(orderByAge))
                {
                    orderByAge.Name = name;
                    orderByAge.Age = age;
                }
                input = Console.ReadLine();
            }

            List<OrderByAge> newOrderByAges = listOfPersons.OrderBy(x => x.Age).ToList();

            foreach (var person in newOrderByAges)
            {
                Console.WriteLine($"{person.Name} with ID: {person.IdOfThePerson} is {person.Age} years old.");
            }

        }

        class OrderByAge
        {
            public OrderByAge(string name, string id, int age)
            {
                this.Name = name;
                this.IdOfThePerson = id;
                this.Age = age;
            }

            public string Name { get; set; }
            public string IdOfThePerson { get; set; }
            public int Age { get; set; }
        }
    }
}
