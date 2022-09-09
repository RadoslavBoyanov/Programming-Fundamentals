using System;

namespace _01DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataTyp = Console.ReadLine();
            string textOrNumber = Console.ReadLine();
            if (dataTyp == "string")
                DataTypeString(dataTyp, textOrNumber);
            else if (dataTyp == "int")
                DataTypes(dataTyp, textOrNumber);
            else if (dataTyp == "real")
                DataType(dataTyp, textOrNumber);
        }


        static void DataTypes(string type, string textOrNumber)
        {
            int integer = int.Parse(textOrNumber);
            if (type == "int")
            {
                Console.WriteLine(integer * 2);
            }
        }

        static void DataType(string type, string realNumber)
        {
            double doubleNumber = double.Parse(realNumber);
            if (type == "real")
            {
                double result = doubleNumber * 1.5;
                Console.WriteLine($"{result:f2}");
            }
        }

        static void DataTypeString(string type, string text)
        {
            if (type == "string")
            {
                Console.WriteLine($"${text}$");
            }
        }
    }
}
