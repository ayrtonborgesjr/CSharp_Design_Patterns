namespace _01_Class_Adapter
{
    public class EnemyRobotAdapter : IEnemyAttack
    {
        EnemyRobot Robot;

        // this contructor method receive the object it'll be Adapted (the Adaptee)
        public EnemyRobotAdapter(EnemyRobot robot)
        {
            this.Robot = robot;
        }

        public void FireWeapon()
        {
            Robot.CrushWithHands();
        }

        public void Fly(string pilot)
        {
            Robot.ReactAgainstHuman(pilot);
        }

        public void Movement()
        {
            Robot.MoveForward();
        }
    }
}
