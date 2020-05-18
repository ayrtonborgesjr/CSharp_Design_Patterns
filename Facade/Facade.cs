using System;

namespace Facade
{
    public class Facade
    {
        private SubSystemOne One;
        private SubSystemTwo Two;
        private SubSystemThree Three;
        private SubSystemFour Four;

        public Facade()
        {
            this.One = new SubSystemOne();
            this.Two = new SubSystemTwo();
            this.Three = new SubSystemThree();
            this.Four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA()-----");
            this.Two.MethodTwo();
            this.Three.MethodThree();
            this.Four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB()-----");
            this.One.MethodOne();
            this.Three.MethodThree();
            this.Four.MethodFour();
        }
    }
}
