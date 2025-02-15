﻿using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");
            Console.WriteLine();

            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
