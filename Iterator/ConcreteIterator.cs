using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate Aggregate;

        private int Current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.Aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return this.Aggregate[this.Current];

        }

        public override object Fist()
        {
            return this.Aggregate[0];
        }

        public override bool IsDone()
        {
            return this.Current >= this.Aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            if (this.Current < this.Aggregate.Count - 1)
            {
                ret = this.Aggregate[++this.Current];
            }

            return ret;
        }
    }
}
