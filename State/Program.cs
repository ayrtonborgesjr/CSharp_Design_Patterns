﻿using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State");
            Console.WriteLine();

            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }
}
