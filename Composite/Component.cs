namespace Composite
{
    public abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract void Show(int depth);

    }
}
