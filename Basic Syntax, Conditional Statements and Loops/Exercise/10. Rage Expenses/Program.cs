using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()); 
            double mousePrice = double.Parse(Console.ReadLine());   
            double keyboardPrice = double.Parse(Console.ReadLine());    
            double displayPrice = double.Parse(Console.ReadLine());

            int trashHeadsets = lostGamesCount / 2;
            int trashMouses = lostGamesCount / 3;
            int trashKeyboards = lostGamesCount / 6;

            int trashDisplay = trashKeyboards / 2;

            double priceTrashHeadsets = trashHeadsets * headsetPrice;
            double priceTrashMouses = trashMouses * mousePrice;
            double priceTrashKeyboards = trashKeyboards * keyboardPrice;
            double priceTrashDisplay = trashDisplay * displayPrice;

            double expenses = priceTrashDisplay + priceTrashHeadsets + priceTrashKeyboards + priceTrashMouses;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
