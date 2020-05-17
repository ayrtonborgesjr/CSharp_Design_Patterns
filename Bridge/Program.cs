using System;
using System.Net.Http.Headers;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge");
            Console.WriteLine();

            SmartTV myTV = new SmartTV();
            Console.WriteLine("PLEASE SELECT A CHANNEL:");
            Console.WriteLine("1 - Movies");
            Console.WriteLine("2 - Documentaries");
            Console.WriteLine("3 - Cooking");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    myTV.SelectedChannel = new Movie();
                    break;
                case '2':
                    myTV.SelectedChannel = new Documentary();
                    break;
                case '3':
                    myTV.SelectedChannel = new Cooking();
                    break;
            }
            
            Console.WriteLine();
            myTV.DisplayTunedChannel();
            myTV.PlayTV();


        }
    }
}
