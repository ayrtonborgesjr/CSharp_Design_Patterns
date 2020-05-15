using System;

namespace _03_Abstract_Factory
{
    public class PopularCarFactory : CarFactory
    {
        public override Stereo AssembleStereo()
        {
            return new CDPlayer();
        }

        public override Wheel AssembleWheeel()
        {
            return new SimpleWheel();
        }
    }
}
