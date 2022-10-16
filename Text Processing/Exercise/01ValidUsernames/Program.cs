using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> validUsersList = new List<string>();

            foreach (var user in userNames)
            {
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < user.Length; i++)
                    {
                        char currentChar = user[i];
                        if (!(currentChar == '-' || currentChar == '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsersList.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsersList));
        }
    }
}
