using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy");
            Console.WriteLine();

            SortedList studentRecords = new SortedList();
            studentRecords.Add("Bob");
            studentRecords.Add("Robert");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Brian");
            studentRecords.Add("Franklin");
            studentRecords.Add("Washington");
            studentRecords.Add("Anderson");
            studentRecords.Add("Clark");


            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
