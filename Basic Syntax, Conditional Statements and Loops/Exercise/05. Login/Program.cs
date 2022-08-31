using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int value = username.Length - 1; value >= 0; value--)
            {
                password += username[value];
            }

            int countOfMistakes = 0;
            string inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {
                countOfMistakes++;
                if (countOfMistakes > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in."); 
            }
        }
    }
}
