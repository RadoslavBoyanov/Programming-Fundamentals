using System;

namespace _03Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringRemover = Console.ReadLine();
            string someString = Console.ReadLine();
            
            int index = someString.IndexOf(stringRemover);
            while (someString.Contains(stringRemover))
            {
                someString = someString.Remove(index, stringRemover.Length);
                index = someString.IndexOf(stringRemover);
            }

            Console.WriteLine(someString);
        }
    }
}
