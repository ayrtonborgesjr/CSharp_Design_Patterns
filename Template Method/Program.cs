using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method");
            Console.WriteLine();

            AbstractClass abstractClassA = new ConcreteClassA();
            abstractClassA.TemplateMethod();

            AbstractClass abstractClassB = new ConcreteClassB();
            abstractClassB.TemplateMethod();

            Console.ReadKey();
        }
    }
}
