using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory!");
            Console.WriteLine();

            Car car1 = RunAbstractFactory.AsselbleCar("lux");

            Car car2 = RunAbstractFactory.AsselbleCar("popular");

            Console.ReadKey();
        }
    }
}
