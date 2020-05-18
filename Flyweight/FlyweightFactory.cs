using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Turtle> TurtleList = new Dictionary<string, Turtle>();

        public Turtle GetTurtle(string color)
        {
            Turtle t = null;

            if (TurtleList.ContainsKey(color))
            {
                t = TurtleList[color];
            }
            else
            {
                switch (color)
                {
                    case "blue": 
                        t = new BlueTurtle(); 
                        break;
                    case "red":
                        t = new RedTurtle();
                        break;
                    case "green":
                        t = new GreenTurtle();
                        break;
                    case "orange":
                        t = new OrangeTurtle();
                        break;
                }

                TurtleList.Add(color, t);
            }

            return t;
        }

        public string FactorySituation()
        {
            StringBuilder str = new StringBuilder();
            str.Append(TurtleList.Count + " - ");
            foreach (var item in TurtleList)
            {
                str.Append(item.Key + ", ");
            }

            return str.ToString();
        }
    }
}
