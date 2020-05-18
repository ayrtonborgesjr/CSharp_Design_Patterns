namespace Decorator
{
    public class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem { get; set; }

        public Decorator(LibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        public override void Show()
        {
            this.LibraryItem.Show();
        }
    }
}
