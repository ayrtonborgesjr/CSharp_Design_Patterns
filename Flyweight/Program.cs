using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----Design Patterns com C# - Flyweight-----+");
            Console.WriteLine();

            FlyweightFactory factory = new FlyweightFactory();

            string cor = string.Empty;

            Turtle turtle = null;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.Write("Which turtle COLOR do you want to show on the screen? ");
                string color = Console.ReadLine();
                turtle = factory.GetTurtle(color);
                turtle.Show(color);
                Console.WriteLine(factory.FactorySituation());
            }
        }
    }
}
