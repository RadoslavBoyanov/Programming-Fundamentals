using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string realPattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";

            int numberOfBarcode = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcode; i++)
            {
                string currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, realPattern))
                {
                    string digits = new String(currentBarcode.Where(char.IsDigit).ToArray());

                    if (digits.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}

