namespace Iterator
{
    public abstract class Iterator
    {
        public abstract object Fist();

        public abstract object Next();
        
        public abstract bool IsDone();

        public abstract object CurrentItem();
    }
}
