﻿using Chain_of_Responsability;
using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility!");
            Console.WriteLine();

            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 24, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }

            Console.ReadKey();
        }
    }
}
