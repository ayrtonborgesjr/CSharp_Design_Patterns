using System;

namespace Flyweight
{
    class OrangeTurtle : Turtle
    {
        public OrangeTurtle()
        {
            this.Condition = "turtle inside the shell, ";
            this.Action = "running on the floor - ";
        }

        public override void Show(string color)
        {
            this.Color = color;
            Console.WriteLine(Condition + Action + Color.ToUpper());
        }
    }
}
