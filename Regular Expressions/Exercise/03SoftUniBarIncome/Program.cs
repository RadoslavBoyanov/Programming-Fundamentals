using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);

                bool isValid = regex.IsMatch(input);

                if (isValid)
                {
                    string name = regex.Match(input).Groups["name"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double priceForProducts = quantity * price;
                    
                    totalIncome += priceForProducts;
                  
                    Console.WriteLine($"{name}: {product} - {priceForProducts:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
