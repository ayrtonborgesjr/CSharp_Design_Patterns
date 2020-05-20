using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator");
            Console.WriteLine();

            ConcreteMediator cm = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(cm);
            ConcreteColleague2 c2 = new ConcreteColleague2(cm);

            cm.Colleague1 = c1;
            cm.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("I'm fine, thank you!");

            Console.ReadKey();
        }
    }
}
