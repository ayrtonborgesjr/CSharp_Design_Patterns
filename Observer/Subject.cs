using System.Collections.Generic;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            this.Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer item in Observers)
            {
                item.Update();
            }
        }

    }
}
