using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        
        public string Title { get; set; }

        public Book(string author, string title, int numberOfCopies)
        {
            this.Author = author;
            this.Title = title;
            this.NumberOfCopies = numberOfCopies;
        }

        public override void Show()
        {
            Console.WriteLine("Book-----\n\tTitle: {0}\n\tAuthor: {1}\n\t# Copy Numbers: {2}", Title, Author, NumberOfCopies);
        }
    }
}
