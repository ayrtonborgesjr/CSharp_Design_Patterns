using System;

namespace Memento
{
    public class Originator
    {
        private string State_;

        public string State
        {
            get { return this.State_; }
            
            set 
            {
                this.State_ = value;
                Console.WriteLine("State = {0}", this.State_);
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(State_));
        }

        public void SetMemento(Memento memento)
        {
            System.Console.WriteLine("Restoring the state...");
            State = memento.State;
        }
    }
}
