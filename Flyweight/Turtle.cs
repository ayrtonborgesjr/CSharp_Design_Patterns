namespace Flyweight
{
    public abstract class Turtle
    {
        protected string Condition; // intrinsic characteristic

        protected string Action; // intrinsic characteristic

        public string Color { get; set; } // extrinsic characteristic

        public abstract void Show(string color);
    }
}
