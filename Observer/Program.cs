using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");
            Console.WriteLine();

            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver("x", s));
            s.Attach(new ConcreteObserver("y", s));
            s.Attach(new ConcreteObserver("z", s));

            s.SubjectState = "ABC";
            s.Notify();

            Console.ReadKey();
        }
    }
}
