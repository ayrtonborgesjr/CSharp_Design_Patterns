using System;

namespace _03_Abstract_Factory
{
    public abstract class CarFactory
    {
        public abstract Wheel AssembleWheeel();
        public abstract Stereo AssembleStereo();
    }
}
