namespace State
{
    public class ConcreteState : State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
