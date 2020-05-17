using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Component
    {
        private readonly List<Component> children = new List<Component>();
        
        public Composite(string Name) : base(Name)
        {

        }

        public override void Add(Component c)
        {
            this.children.Add(c);
        }

        public override void Remove(Component c)
        {
            this.children.Remove(c);
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            
            foreach (var item in this.children)
            {
                item.Show(depth + 2);
            }
        }
    }
}
