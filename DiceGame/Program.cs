using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija kes viskas rohkem ongi võitja
            //programm kuulutab võitja

            Random rnd = new Random();

            string player1 = "Harry Potter";
            string player2 = "Voldemort";

            int harryThrow = rnd.Next(1, 7);
            int voldemortThrow = rnd.Next(1, 7);

            if (harryThrow > voldemortThrow)
            {
                Console.WriteLine($"{player1} wins!");
            }
            else if (harryThrow < voldemortThrow)
            {
                Console.WriteLine($"{player2} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw, try again!");
            }

        }
    }
}
