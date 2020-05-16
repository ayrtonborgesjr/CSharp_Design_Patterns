using System;

namespace _01_Class_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Adapter!");
            Console.WriteLine();

            EnemyTank Rx2018 = new EnemyTank();
            EnemyRobot R2D2 = new EnemyRobot();

            IEnemyAttack robot_Adapter = new EnemyRobotAdapter(R2D2);

            Console.WriteLine("==============================ROBOT==============================");
            R2D2.ReactAgainstHuman("Rob");
            R2D2.MoveForward();
            R2D2.CrushWithHands();
            Console.WriteLine("=================================================================");

            Console.WriteLine();

            Console.WriteLine("==============================TANK==============================");
            Rx2018.Fly("Donald");
            Rx2018.Movement();
            Rx2018.FireWeapon();
            Console.WriteLine("=================================================================");

            Console.WriteLine();

            Console.WriteLine("==========================ROBOT ADAPTER=========================");
            robot_Adapter.Fly("Obama");
            robot_Adapter.Movement();
            robot_Adapter.FireWeapon();
            Console.WriteLine("=================================================================");

            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
