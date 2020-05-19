using System;

namespace Command
{
    public abstract class Command
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public abstract void Execute();
    }
}
