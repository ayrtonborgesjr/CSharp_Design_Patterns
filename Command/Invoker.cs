using System;

namespace Command
{
    public class Invoker
    {
        private Command Command;

        public void SetCommand(Command command)
        {
            this.Command = command;
        }

        public void ExecuteCommand()
        {
            this.Command.Execute();
        }
    }
}
