using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge Sorted list ") ;
        }
    }
}
