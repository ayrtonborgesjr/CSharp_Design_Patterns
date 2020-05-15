using System;

namespace _02_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method!");
            Console.WriteLine();

            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.Write("Choose your Character: ");
            string choice = Console.ReadLine();

            ICharacter character = fm.ChooseCharacter(choice);
            Console.WriteLine();

            Console.Write("You'll play with : ");
            character.Selected();

            Console.ReadKey();
        }
    }
}
