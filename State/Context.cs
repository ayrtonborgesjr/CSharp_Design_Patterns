using System;

namespace State
{
    public class Context
    {
        private State State_;

        public Context(State state)
        {
            this.State_ = state;
        }

        public State State
        {
            get { return this.State; }
            
            set
            {
                this.State_ = value;
                Console.WriteLine("State: {0}", this.State_.GetType().Name);
            }
        }

        public void Request()
        {
            this.State_.Handler(this);
        }
    }
}
