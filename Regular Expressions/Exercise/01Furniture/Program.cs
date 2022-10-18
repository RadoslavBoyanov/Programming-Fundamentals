using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _01Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9.]+)!(?<quantity>\d+)";
           
            var listOfBoughtFurniture = new List<string>();
            

            double totalMoneySpend = 0;
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    listOfBoughtFurniture.Add(name);
                    totalMoneySpend += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (listOfBoughtFurniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, listOfBoughtFurniture));
            }

            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
