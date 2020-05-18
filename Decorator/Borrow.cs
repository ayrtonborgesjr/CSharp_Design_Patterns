using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Borrow : Decorator
    {
        protected List<string> BorrowItems = new List<string>();

        public Borrow(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string customerName)
        {
            this.BorrowItems.Add(customerName);
            this.LibraryItem.NumberOfCopies--;
        }

        public void ReturnBorrowItem(string customerName)
        {
            this.BorrowItems.Remove(customerName);
            this.LibraryItem.NumberOfCopies++;
        }

        public override void Show()
        {
            base.Show();
            
            foreach (string item in this.BorrowItems)
            {
                Console.WriteLine("Customer: {0}", item);
            }
        }
    }
}
