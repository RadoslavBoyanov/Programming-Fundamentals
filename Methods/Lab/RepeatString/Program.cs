using System;
using System.Text;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

           string result = RepeaterString(text, repeat);
           Console.WriteLine(result);
        }

        static string RepeaterString(string text, int repeat)
        {
            StringBuilder resultBuilder = new StringBuilder();
            for (int i = 0; i < repeat; i++)
                resultBuilder.Append(text);
            return resultBuilder.ToString();
        }
    }
}

