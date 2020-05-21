namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
