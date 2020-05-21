using System;
using System.Collections.Generic;


namespace Strategy
{
    public class SortedList
    {
        private List<string> List = new List<string>();
        
        private SortStrategy SortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.SortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            this.List.Add(name);
        }

        public void Sort()
        {
            SortStrategy.Sort(this.List);

            foreach (string name in this.List)
            {
                Console.WriteLine(" {0}", name);
            }
            
            Console.WriteLine();
        }
    }
}
