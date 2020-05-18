using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator!");
            Console.WriteLine();

            // Create Book
            Book myBook = new Book("GOF (Gang Of Four)", "Design Patterns", 10);
            myBook.Show();

            // Create Video
            Video myVideo = new Video("Home Alone", "Chris Columbus", 103, 3);
            myVideo.Show();

            // Borrow video and show it
            Console.WriteLine("\nDOING A BORROW");
            Borrow borrow = new Borrow(myVideo);
            borrow.BorrowItem("Bob");
            borrow.BorrowItem("John");
            borrow.Show();

            Console.WriteLine("\nDOING A RETURN");
            borrow.ReturnBorrowItem("Bob");
            borrow.Show();

            Console.ReadKey();
        }
    }
}
