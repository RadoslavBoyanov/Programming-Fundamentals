using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool isPasswordLenghtValid = Characters(inputPassword);
            bool isPasswordConsistLettersAndDigts = PasswordWithTwoDigits(inputPassword);
            var isPasswordHas2Digits = ConsistLettersAndDigits(inputPassword);

            if (!isPasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordConsistLettersAndDigts)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordHas2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (isPasswordHas2Digits && isPasswordLenghtValid && isPasswordConsistLettersAndDigts)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Characters(string input)
        {
            return input.Length >= 6 && input.Length <= 10;
        }

        static bool ConsistLettersAndDigits(string input)
        {
            int count = 0;
            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            return count >= 2;
        }

        static bool PasswordWithTwoDigits(string input)
        {
            foreach (char chara in input)
            {
                if (!char.IsLetterOrDigit(chara))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
