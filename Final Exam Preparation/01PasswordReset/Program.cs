using System;
using System.Text;

namespace _01PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            StringBuilder newPassword = new StringBuilder();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] tokensCmd = command.Split(" ");
                
                string action = tokensCmd[0];

                switch (action)
                {
                    case "TakeOdd":
                    {
                        for (int i = 1; i <= password.Length - 1; i += 2)
                        {
                            newPassword.Append(password[i]);
                        }
                        password = newPassword.ToString();
                        Console.WriteLine(password);
                        break;
                    }
                    case "Cut":
                    {
                        int index = int.Parse(tokensCmd[1]);
                        int length = int.Parse(tokensCmd[2]);
                        
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    }
                    case "Substitute":
                    {
                        string substring = tokensCmd[1];
                        string substitute = tokensCmd[2];
                        if (password.Contains(substring)) 
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else if(!password.Contains(substring))
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
