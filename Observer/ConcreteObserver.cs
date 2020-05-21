using System;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private string Nome;

        private string ObserverState;

        private ConcreteSubject ConcreteSubject;
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(string nome, ConcreteSubject concreteSubject)
        {
            Nome = nome;
            ConcreteSubject = concreteSubject;
        }

        public override void Update()
        {
            this.ObserverState = this.ConcreteSubject.SubjectState;
            Console.WriteLine("Observer {0}, your new State is {1}",this.Nome, this.ObserverState);
        }
    }
}
