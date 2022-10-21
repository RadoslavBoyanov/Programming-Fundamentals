using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Decode")
            {
                string[] tokensCmd = commands.Split("|");
                string operation = tokensCmd[0];

                switch (operation)
                {
                    case "Move":
                    {
                        int numberOfLetters = int.Parse(tokensCmd[1]);
                        string add = string.Empty;
                        for (int i = 0; i < numberOfLetters; i++)
                        {
                            add += encryptedMessage[i];
                        }

                        encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                        encryptedMessage += add; 
                        break;
                    }
                    case "Insert":
                    {
                        int index = int.Parse(tokensCmd[1]);
                        string value = tokensCmd[2];
                        encryptedMessage = encryptedMessage.Insert(index, value);
                        break;
                    }
                    case "ChangeAll":
                    {
                        string substring = tokensCmd[1];
                        string replacement = tokensCmd[2];
                        encryptedMessage = encryptedMessage.Replace(substring, replacement);
                        break;
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
