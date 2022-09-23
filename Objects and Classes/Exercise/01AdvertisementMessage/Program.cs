using System;

namespace _01AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authorNames = new string[]{ "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[]{ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrase = new Random();
            Random even = new Random();
            Random author = new Random();
            Random sity = new Random();

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);
                int eventIndex = even.Next(0, events.Length);
                int authorIndex = author.Next(0, authorNames.Length);
                int citiIndex = sity.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authorNames[authorIndex]} - {cities[citiIndex]}");
            }
        }
    }
}
