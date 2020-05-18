using System;

namespace Decorator
{
    public class Video : LibraryItem
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public int RunningTime { get; set; }

        public Video(string title, string director, int runningTime, int numberOfCopies)
        {
            this.Title = title;
            this.Director = director;
            this.RunningTime = runningTime;
            this.NumberOfCopies = numberOfCopies;
        }

        public override void Show()
        {
            Console.WriteLine("Video-----\n\tTitle: {0}\n\tDirector: {1}\n\t# Running Time: {2}\n\t# Copy Numbers: {3}", Title, Director, RunningTime, NumberOfCopies);
        }
    }
}
