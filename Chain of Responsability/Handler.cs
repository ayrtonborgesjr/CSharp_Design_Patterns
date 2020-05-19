namespace Chain_of_Responsability
{
    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandlerRequest(int request);
    }
}
