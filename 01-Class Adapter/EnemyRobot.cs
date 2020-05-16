using System;

namespace _01_Class_Adapter
{
    // this class is Adaptee - it'll be adapted by EnemyRobotAdapter
    public class EnemyRobot
    {
        Random randomize = new Random();
        
        public void CrushWithHands()
        {
            int attackDamage = this.randomize.Next(10) + 1;
            Console.WriteLine("The enemy robot did {0} damage with the Hand Smash Attack!", attackDamage);
        }
        
        public void MoveForward()
        {
            int movement = this.randomize.Next(10) + 1;
            Console.WriteLine("The enemy robot walked {0} steps forward!", movement);
        }
        
        public void ReactAgainstHuman(string pilot)
        {
            Console.WriteLine("The enemy robot reacts against the {0} ", pilot);
        }
    }
}
