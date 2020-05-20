namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 Colleague1_;
        
        private ConcreteColleague2 Colleague2_;

        public ConcreteColleague1 Colleague1
        {
            set { this.Colleague1_ = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { this.Colleague2_ = value; }
        }
        
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.Colleague1_)
            {
                this.Colleague2_.Notify(message);
            }
            else
            {
                this.Colleague1_.Notify(message);
            }
        }
    }
}
