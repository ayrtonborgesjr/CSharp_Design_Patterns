using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade!");
            Console.WriteLine();

            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

             Console.ReadKey();
        }
    }
}
