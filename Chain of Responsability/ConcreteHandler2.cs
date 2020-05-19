using System;

namespace Chain_of_Responsability
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
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
