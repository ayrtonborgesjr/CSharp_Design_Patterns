using System;

namespace Chain_of_Responsability
{
    class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} Handled Request {1}", this.GetType().Name, request);
            }
            else if (Successor != null)
            {
                Successor.HandlerRequest(request);
            }
        }
    }
}
