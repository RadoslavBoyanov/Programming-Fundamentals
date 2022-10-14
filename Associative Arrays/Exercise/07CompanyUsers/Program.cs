using System;
using System.Collections.Generic;

namespace _07CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            
           
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }

                if (companyUsers[companyName].Contains(employeeId))
                {
                    input = Console.ReadLine();
                    continue;
                }

                companyUsers[companyName].Add(employeeId);

                input = Console.ReadLine();

            }

            foreach (var company in companyUsers)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employe in company.Value)
                {
                    Console.WriteLine($"-- {employe}");
                }
            }
        }
    }
}
