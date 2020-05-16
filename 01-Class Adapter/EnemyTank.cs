using System;

namespace _01_Class_Adapter
{
    public class EnemyTank : IEnemyAttack
    {
        Random randomize = new Random();
        public void FireWeapon()
        {
            int attackDamage = this.randomize.Next(10) + 1;
            Console.WriteLine("Enemy Tank car dealt  {0} of damage!", attackDamage);
        }

        public void Fly(string pilot)
        {
            Console.WriteLine("{0} is in charge of the Enemy Tank now!", pilot);
        }

        public void Movement()
        {
            int movement = this.randomize.Next(5) + 1;
            Console.WriteLine("Enemy tank walked " + movement + " steps!");
        }
    }
}
