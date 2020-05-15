using System;

namespace _01_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton!");

            Singleton player1 = Singleton.GetInstance;
            player1.Message("Player 1 has the ball in the middle of the field!");

            Singleton player2 = Singleton.GetInstance;
            player1.Message("Player 2 received the ball!");

            Singleton player3 = Singleton.GetInstance;
            player1.Message("Player 3 received the ball on the bottom line!");

            Console.ReadKey();
        }
    }
}
