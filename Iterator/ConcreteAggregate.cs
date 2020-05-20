using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList Items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return Items.Count; }
        }

        public object this[int index]
        {
            get { return Items[index]; }
            set { Items.Insert(index, value); }
        }
    }
}
