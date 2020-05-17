using System;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(string Name) : base(Name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Unable to Add 'Leaf'!");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Unable to Remove 'Leaf'!");
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
